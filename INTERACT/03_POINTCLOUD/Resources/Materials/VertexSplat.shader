// Copyright (C) 2017 CEA LIST, DRT/DIASI/LSI
// Author: Jeremie Le Garrec
// jeremie_legarrec@hotmail.com

Shader "Custom/VertexSplat"
{
    Properties
    {
        _MainTex ("Diffuse Texture", 2D) = "white" {}
        _AlphaTex ("Alpha Mask", 2D) = "white" {}
        _DiffuseTint ( "Diffuse Tint", Color) = (1, 1, 1, 1)
        _Size ("Splat Size", float) = 0.005
        _Cutoff ("Alpha Cutoff", Float) = 0.5
    }
    SubShader
    {
        Tags
        {
            "RenderType" = "Opaque" "Queue" = "Geometry"
        }
        Pass
        {

            // 1.) This will be the base forward rendering pass in which ambient, vertex, and
            // main directional light will be applied. Additional lights will need additional passes
            // using the "ForwardAdd" lightmode.
            // see: http://docs.unity3d.com/Manual/SL-PassTags.html
            //Tags { "LightMode" = "ForwardAdd"}
            Tags
            {
                "LightMode" = "ForwardBase"
            }

            LOD 200

            CGPROGRAM
            #pragma target 5.0
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma vertex vert
            #pragma geometry GS_Main
            #pragma fragment frag

            // 2.) This matches the "forward base" of the LightMode tag to ensure the shader compiles
            // properly for the forward bass pass. As with the LightMode tag, for any additional lights
            // this would be changed from _fwdbase to _fwdadd.
            //#pragma multi_compile_fwdbase

            // 3.) Reference the Unity library that includes all the lighting shadow macros
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"

            // Vert to geo
            struct v2g
            {
                float4 pos : SV_POSITION;
                float4 color: COLOR;

                UNITY_VERTEX_OUTPUT_STEREO
            };

            // geo to frag
            struct g2f
            {
                float4 pos : SV_POSITION;
                float4 color: COLOR;
                float2 uv : TEXCOORD1;

                UNITY_VERTEX_INPUT_INSTANCE_ID
                UNITY_VERTEX_OUTPUT_STEREO
            };


            // Vars
            uniform sampler2D _MainTex;
            uniform sampler2D _AlphaTex;
            uniform float4 _DiffuseTint;
            uniform float _Size;
            uniform float _Cutoff;

            // Vertex modifier function
            v2g vert(appdata_full v)
            {
                v2g o = (v2g)0;

                UNITY_SETUP_INSTANCE_ID(v);
                UNITY_INITIALIZE_OUTPUT(v2g, o);
                UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(o);

                o.pos = mul(unity_ObjectToWorld, v.vertex);
                o.color = v.color;

                TRANSFER_VERTEX_TO_FRAGMENT(o);

                return o;
            }

            // GS_Main(point v2g p[1], inout TriangleStream<g2f> triStream)
            // GS_Main(line v2g p[2], inout TriangleStream<g2f> triStream)
            // GS_Main(triangle v2g p[3], inout TriangleStream<g2f> triStream)
            [maxvertexcount(4)]
            void GS_Main(point v2g p[1], inout TriangleStream<g2f> triStream)
            {
                float4 v[4];
                float4 objPos = mul(unity_WorldToObject, p[0].pos);
                float3 upVector = mul(UNITY_MATRIX_T_MV, float4(0, 1, 0, 0));
                float3 eyeVector = ObjSpaceViewDir(objPos);
                float3 rightVector = normalize(cross(eyeVector, upVector));

                v[0] = float4(objPos + _Size * rightVector - _Size * upVector, 1.0f);
                v[1] = float4(objPos + _Size * rightVector + _Size * upVector, 1.0f);
                v[2] = float4(objPos - _Size * rightVector - _Size * upVector, 1.0f);
                v[3] = float4(objPos - _Size * rightVector + _Size * upVector, 1.0f);

                g2f pIn = (g2f)0;
                pIn.pos = UnityObjectToClipPos(v[0]);
                pIn.color = p[0].color;
                pIn.uv = float2(0, 0);
                triStream.Append(pIn);

                pIn.pos = UnityObjectToClipPos(v[2]);
                pIn.color = p[0].color;
                pIn.uv = float2(1, 0);
                triStream.Append(pIn);

                pIn.pos = UnityObjectToClipPos(v[1]);
                pIn.color = p[0].color;
                pIn.uv = float2(0, 1);
                triStream.Append(pIn);

                pIn.pos = UnityObjectToClipPos(v[3]);
                pIn.color = p[0].color;
                pIn.uv = float2(1, 1);
                triStream.Append(pIn);
            }

            //float4 frag(g2f i) : SV_Target
            //{
            //    float4 alpha_mask = tex2D(_AlphaTex, i.uv); 
            //    // alpha value less than user-specified threshold?
            //    clip(alpha_mask.a - _Cutoff) ;
            //    float4 out_color = _DiffuseTint * i.color;
            //    return out_color;
            //  }

            fixed4 frag(g2f i) : SV_Target
            {
                UNITY_SETUP_STEREO_EYE_INDEX_POST_VERTEX(i);

                fixed4 alpha_mask = tex2D(_AlphaTex, i.uv);
                // alpha value less than user-specified threshold?
                clip(alpha_mask.a - _Cutoff);
                fixed4 out_color = _DiffuseTint * i.color;
                return out_color;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
}