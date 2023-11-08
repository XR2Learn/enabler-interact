
// https://docs.unity3d.com/Manual/ScriptingRestrictions.html 
// To work around an AOT issue like this, we force the compiler to generate the proper code.

#if ENABLE_IL2CPP

namespace XdeEngine.IL2CPP
{
  class Basic_zmq
  {
    [UnityEngine.Scripting.Preserve]
    static void ForceRegistrationOfMethod()
    {
      XdeNetwork.XdeInterConnection mm1 = new XdeNetwork.XdeInterConnection();
      XdeNetwork.XdeZMQContext mm2 = new XdeNetwork.XdeZMQContext();
      XdeNetwork.XdeZMQLVC mm3 = new XdeNetwork.XdeZMQLVC();
      XdeNetwork.XdeZMQPublisher mm4 = new XdeNetwork.XdeZMQPublisher();
      XdeNetwork.XsmZMQServer mm5 = new XdeNetwork.XsmZMQServer();
    }
  }
}
#endif
