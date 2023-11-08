// ===========================
// GENERATED CODE, DO NOT EDIT
// generated at 2023-08-09 16:55:04.863000
// from template 'cs/modules_components_uwp_cs.tpl'
// ===========================
#if ENABLE_IL2CPP

// https://docs.unity3d.com/Manual/ScriptingRestrictions.html 
// To work around an AOT issue like this, we force the compiler to generate the proper code.
namespace XdeEngine.IL2CPP
{
  class Basic_opc_opc_ua
  {
    [UnityEngine.Scripting.Preserve]
    static void ForceRegistrationOfMethod()
    {
      // The factory must be registered.
      xde.client.opc.PluginFactory tmp2 = new xde.client.opc.PluginFactory();

      // Register all the types
      System.IO.FileStream str = new System.IO.FileStream("/C/tmp/", System.IO.FileMode.Create);
      byte[] bts = new byte[0];
      //xde_types.opc.xde_opc_id_type
      {
        var ser = new xde_types.opc.xde_opc_id_type();
        xde_types.opc.opc_id_type elmt = xde_types.opc.xde_opc_id_type.default_value();
        bool tmp = xde_types.opc.xde_opc_id_type.fixedSize;
        xde_types.opc.xde_opc_id_type.size(ref elmt);
        xde_types.opc.xde_opc_id_type.serialize(bts, elmt, 0);
        xde_types.opc.xde_opc_id_type.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      

    }
  };
}
#endif // ENABLE_IL2CPP