#include "UnityCG.cginc"
//#include "AutoLight.cginc"

struct appdata
{
    float4 vertex : POSITION;
    half3 color : COLOR;

    UNITY_VERTEX_INPUT_INSTANCE_ID
};

struct v2f
{
    float4 vertex : POSITION;
    half3 color : COLOR;

    UNITY_VERTEX_OUTPUT_STEREO
};

struct v2g
{
    float4 pos : SV_POSITION;
    #if !OCTOPCL_SHADOW_CASTER
    half3 color : COLOR;
    #endif
    float splat : TEXCOORD0;

    UNITY_VERTEX_INPUT_INSTANCE_ID
};

struct g2f
{
    float4 pos : SV_POSITION;
    #if !OCTOPCL_SHADOW_CASTER
    half3 color : COLOR;
    #endif
    float2 uv : TEXCOORD0;
    float4 viewpos : TEXCOORD1;
    #if OCTOPCL_BSP || OCTOPCL_BOX_SELECTION
    float4 worldpos : TEXCOORD2;
    #endif

    UNITY_VERTEX_OUTPUT_STEREO
};

//fragment out
struct fo
{
#if !OCTOPCL_SHADOW_CASTER
    float4 color : SV_TARGET;
#endif
    float depth : SV_DEPTH;
};

// Vars
uniform float4 _DiffuseTint;

#if OCTOPCL_COLOR_GRADIENT_Y
sampler2D _GradientTx;
uniform float _Height;
#endif

#if OCTOPCL_BSP
uniform float4 _planeEquation;
uniform int _cuttingOn;
#endif

uniform int _orthographic;

#if OCTOPCL_BOX_SELECTION
uniform half4 _selectionColorIn;
uniform half4 _selectionColorOut;
#endif

// Vertex modifier function
v2g Vertex(appdata v)
{
    UNITY_SETUP_INSTANCE_ID(v);
    
    v2g o;

    UNITY_TRANSFER_INSTANCE_ID(v, o);

    o.pos = v.vertex;
#if !OCTOPCL_SHADOW_CASTER
# ifdef UNITY_COLORSPACE_GAMMA
  o.color = v.color;
# else
    o.color = GammaToLinearSpace(v.color);
# endif
#endif
    o.splat = SplatSize(v.vertex);
    return o;
}

[maxvertexcount(3)]
void Geometry(point v2g p[1], inout TriangleStream<g2f> triStream)
{
    UNITY_SETUP_INSTANCE_ID(p[0]);
    
    float3 upVector = mul(UNITY_MATRIX_T_MV, float4(0, 1, 0, 0));
    float3 eyeVector;
    float3 rightVector;
    if (!_orthographic)
    {
        eyeVector = ObjSpaceViewDir(p[0].pos);
        rightVector = normalize(cross(eyeVector, upVector));
    }
    else
    {
        eyeVector = mul(UNITY_MATRIX_T_MV, float4(0, 0, 1, 0));
        rightVector = mul(UNITY_MATRIX_T_MV, float4(1, 0, 0, 0));
    }
    //float extend = p[0].splat * 1.73205080757f;
    //add extend to cover splat
    float extend = 1.5f * p[0].splat * 1.73205080757f;

    float4 v[3];
    v[0] = float4(p[0].pos - extend * rightVector - extend * 0.57735026919f * upVector, 1.0f);
    v[1] = float4(p[0].pos + extend * 1.15470053838f * upVector, 1.0f);
    v[2] = float4(p[0].pos + extend * rightVector - extend * 0.57735026919f * upVector, 1.0f);

    g2f pIn = (g2f)0;
    UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(pIn);

    pIn.pos = UnityObjectToClipPos(v[0]);
    pIn.viewpos.xyz = UnityObjectToViewPos(v[0]);
    pIn.viewpos.w = extend;
#if !OCTOPCL_SHADOW_CASTER
    pIn.color = p[0].color;
#endif
    pIn.uv = float2(-1.73205080757f, -1.0f);
#if OCTOPCL_BSP
    pIn.worldpos = mul(unity_ObjectToWorld, v[0]);
#endif

    triStream.Append(pIn);

    pIn.pos = UnityObjectToClipPos(v[1]);
    pIn.viewpos.xyz = UnityObjectToViewPos(v[1]);
    pIn.viewpos.w = extend;
#if !OCTOPCL_SHADOW_CASTER
    pIn.color = p[0].color;
#endif
    pIn.uv = float2(0.0f, 2.0f);
#if OCTOPCL_BSP
    pIn.worldpos = mul(unity_ObjectToWorld, v[1]);
#endif

    triStream.Append(pIn);

    pIn.pos = UnityObjectToClipPos(v[2]);
    pIn.viewpos.xyz = UnityObjectToViewPos(v[2]);
    pIn.viewpos.w = extend;
#if !OCTOPCL_SHADOW_CASTER
    pIn.color = p[0].color;
#endif
    pIn.uv = float2(1.73205080757f, -1.0f);
#if OCTOPCL_BSP
    pIn.worldpos = mul(unity_ObjectToWorld, v[2]);
#endif

    triStream.Append(pIn);
}

fo Fragment(g2f i)
{
    fo fragout;

#if !OCTOPCL_SHADOW_CASTER
# if OCTOPCL_COLOR_GRADIENT_Y && (OCTOPCL_BSP || OCTOPCL_BOX_SELECTION)
    float4 color = tex2D(_GradientTx, float2(i.worldpos.y / _Height, 0));
# else
    float4 color = float4(i.color, 1);
# endif
#endif

#if OCTOPCL_BSP
    if (_cuttingOn)
    {
        //clip(dot(i.worldpos, _planeEquation.xyz) - _planeEquation.w);
        float plane_dot = dot(i.worldpos, _planeEquation.xyz) - _planeEquation.w;
        clip(plane_dot);
# if !OCTOPCL_SHADOW_CASTER
        if (plane_dot < 0.004)
        {
            color = float4(1, 0, 0, 1);
        }
# endif
    }
#endif

    clip(dot(i.uv, i.uv) > 1.0f ? -1 : 1);

#if OCTOPCL_BOX_SELECTION && !OCTOPCL_SHADOW_CASTER
    color *= (insideBox(i.worldpos) ? _selectionColorIn : _selectionColorOut);
#endif

    i.viewpos.z += (1 - length(i.uv)) * i.viewpos.w;

    float4 pos = mul(UNITY_MATRIX_P, float4(i.viewpos.xyz, 1.0f));
    pos /= pos.w;

    fragout.depth = pos.z;
    
#if !OCTOPCL_SHADOW_CASTER
    fragout.color = _DiffuseTint * color;
#else
    //SHADOW_CASTER_FRAGMENT(i)
#endif

    return fragout;
}
