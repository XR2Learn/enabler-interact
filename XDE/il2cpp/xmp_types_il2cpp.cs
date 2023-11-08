
// In order to use the serialization assembly in a unity project for an AOT platform
// (see https://docs.unity3d.com/Manual/ScriptingRestrictions.html)
// this file must be included as source in a unity project, in order to force generation of code

namespace xsm.serialization.msgpack.IL2CPP
{
  class XmpTypes
  {
    // This force AOT computation
    [UnityEngine.Scripting.Preserve]
    static void ForceRegistrationOfMethod()
    {
      {
        System.IO.MemoryStream str = new System.IO.MemoryStream();
        var ser = new xsm.serialization.msgpack.xmp_peer_info();
        xsm2.PeerInfo elmt = ser.DefaultValue();
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }

      {
        System.IO.MemoryStream str = new System.IO.MemoryStream();
        var ser = new xsm.serialization.msgpack.xmp_peer_type();
        xsm2.XsmPeerType elmt = ser.DefaultValue();
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }

    }
  }
}
