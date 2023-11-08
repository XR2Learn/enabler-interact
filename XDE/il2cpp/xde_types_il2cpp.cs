
// In order to use the serialization assembly in a unity project for an AOT platform
// (see https://docs.unity3d.com/Manual/ScriptingRestrictions.html)
// this file must be included as source in a unity project, in order to force generation of code

namespace xsm.serialization.msgpack.IL2CPP
{
  class BasicTypes
  {

    // This force AOT computation
    [UnityEngine.Scripting.Preserve]
    static void ForceRegistrationOfMethod()
    {

      // This specific Dictionary constructor must be registered
      xsm.serialization.msgpack.DictionarySerializer<string, System.Collections.Generic.Dictionary<string, string>> dico =
        new xsm.serialization.msgpack.DictionarySerializer<string, System.Collections.Generic.Dictionary<string, string>>();

      // templates for serialization of basic types
      System.IO.MemoryStream str = new System.IO.MemoryStream();
      byte[] bts = new byte[0];


      // xsm.serialization.msgpack.xmp_bool
      {
        var ser = new xsm.serialization.msgpack.xmp_bool();
        bool elmt = ser.DefaultValue();
        bool tmp = xsm.serialization.msgpack.xmp_bool.fixedSize;
        xsm.serialization.msgpack.xmp_bool.size(ref elmt);
        xsm.serialization.msgpack.xmp_bool.serialize(bts, elmt, 0);
        xsm.serialization.msgpack.xmp_bool.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }

      //xsm.serialization.msgpack.xmp_integer (int)
      {
        var ser = new xsm.serialization.msgpack.xmp_integer();
        int elmt = ser.DefaultValue();
        bool tmp = xsm.serialization.msgpack.xmp_integer.fixedSize;
        xsm.serialization.msgpack.xmp_integer.size(ref elmt);
        xsm.serialization.msgpack.xmp_integer.serialize(bts, elmt, 0);
        xsm.serialization.msgpack.xmp_integer.deserialize(bts, ref elmt, 0);
        ser.Read(str, ref elmt);
        ser.Write(str, elmt);
      }

      //xsm.serialization.msgpack.xmp_long_integer (long)
      {
        var ser = new xsm.serialization.msgpack.xmp_long_integer();
        long elmt = ser.DefaultValue();
        bool tmp = xsm.serialization.msgpack.xmp_long_integer.fixedSize;
        xsm.serialization.msgpack.xmp_long_integer.size(ref elmt);
        xsm.serialization.msgpack.xmp_long_integer.serialize(bts, elmt, 0);
        xsm.serialization.msgpack.xmp_long_integer.deserialize(bts, ref elmt, 0);
        ser.Read(str, ref elmt);
        ser.Write(str, elmt);
      }

      //xsm.serialization.msgpack.xmp_fixed32_integer (uint)
      {
        var ser = new xsm.serialization.msgpack.xmp_fixed32_integer();
        System.UInt32 elmt = ser.DefaultValue();
        bool tmp = xsm.serialization.msgpack.xmp_fixed32_integer.fixedSize;
        xsm.serialization.msgpack.xmp_fixed32_integer.size(ref elmt);
        xsm.serialization.msgpack.xmp_fixed32_integer.serialize(bts, elmt, 0);
        xsm.serialization.msgpack.xmp_fixed32_integer.deserialize(bts, ref elmt, 0);
        ser.Read(str, ref elmt);
        ser.Write(str, elmt);
      }



      // xsm.serialization.msgpack.xmp_float
      {
        var ser = new xsm.serialization.msgpack.xmp_float();
        float elmt = ser.DefaultValue();
        bool tmp = xsm.serialization.msgpack.xmp_float.fixedSize;
        xsm.serialization.msgpack.xmp_float.size(ref elmt);
        xsm.serialization.msgpack.xmp_float.serialize(bts, elmt, 0);
        xsm.serialization.msgpack.xmp_float.deserialize(bts, ref elmt, 0);
        ser.Read(str, ref elmt);
        ser.Write(str, elmt);
      }

      // xsm.serialization.msgpack.xmp_double
      {
        var ser = new xsm.serialization.msgpack.xmp_double();
        double elmt = ser.DefaultValue();
        bool tmp = xsm.serialization.msgpack.xmp_double.fixedSize;
        xsm.serialization.msgpack.xmp_double.size(ref elmt);
        xsm.serialization.msgpack.xmp_double.serialize(bts, elmt, 0);
        xsm.serialization.msgpack.xmp_double.deserialize(bts, ref elmt, 0);
        ser.Read(str, ref elmt);
        ser.Write(str, elmt);
      }

      // xsm.serialization.msgpack.xmp_string
      {
        var ser = new xsm.serialization.msgpack.xmp_string();
        string elmt = ser.DefaultValue();
        bool tmp = xsm.serialization.msgpack.xmp_string.fixedSize;
        xsm.serialization.msgpack.xmp_string.size(ref elmt);
        xsm.serialization.msgpack.xmp_string.serialize(bts, elmt, 0);
        xsm.serialization.msgpack.xmp_string.deserialize(bts, ref elmt, 0);
        ser.Read(str, ref elmt);
        ser.Write(str, elmt);
      }

      //xsm.serialization.msgpack.xmp_bytearray
      {
        var ser = new xsm.serialization.msgpack.xmp_bytearray();
        byte[] elmt = ser.DefaultValue();
        bool tmp = xsm.serialization.msgpack.xmp_bytearray.fixedSize;
        xsm.serialization.msgpack.xmp_bytearray.size(ref elmt);
        xsm.serialization.msgpack.xmp_bytearray.serialize(bts, elmt, 0);
        xsm.serialization.msgpack.xmp_bytearray.deserialize(bts, ref elmt, 0);
        ser.Read(str, ref elmt);
        ser.Write(str, elmt);
      }

      // xsm.serialization.msgpack.xmp_displacementf
      {
        var ser = new xsm.serialization.msgpack.xmp_displacementf();
        xde.unity.math.Displacement elmt = ser.DefaultValue();
        bool tmp = xsm.serialization.msgpack.xmp_displacementf.fixedSize;
        xsm.serialization.msgpack.xmp_displacementf.size(ref elmt);
        xsm.serialization.msgpack.xmp_displacementf.serialize(bts, elmt, 0);
        xsm.serialization.msgpack.xmp_displacementf.deserialize(bts, ref elmt, 0);
        ser.Read(str, ref elmt);
        ser.Write(str, elmt);
      }

      // xsm.serialization.msgpack.xmp_displacementd
      {
        var ser = new xsm.serialization.msgpack.xmp_displacementd();
        xde.unity.math.Displacementd elmt = ser.DefaultValue();
        bool tmp = xsm.serialization.msgpack.xmp_displacementd.fixedSize;
        xsm.serialization.msgpack.xmp_displacementd.size(ref elmt);
        xsm.serialization.msgpack.xmp_displacementd.serialize(bts, elmt, 0);
        xsm.serialization.msgpack.xmp_displacementd.deserialize(bts, ref elmt, 0);
        ser.Read(str, ref elmt);
        ser.Write(str, elmt);
      }

      // xsm.serialization.msgpack.xmp_wrenchd
      {
        var ser = new xsm.serialization.msgpack.xmp_wrenchd();
        xde.unity.math.Wrench elmt = ser.DefaultValue();
        bool tmp = xsm.serialization.msgpack.xmp_wrenchd.fixedSize;
        xsm.serialization.msgpack.xmp_wrenchd.size(ref elmt);
        xsm.serialization.msgpack.xmp_wrenchd.serialize(bts, elmt, 0);
        xsm.serialization.msgpack.xmp_wrenchd.deserialize(bts, ref elmt, 0);
        ser.Read(str, ref elmt);
        ser.Write(str, elmt);
      }

      // xsm.serialization.msgpack.xmp_twistd
      {
        var ser = new xsm.serialization.msgpack.xmp_twistd();
        xde.unity.math.Twist elmt = ser.DefaultValue();
        bool tmp = xsm.serialization.msgpack.xmp_twistd.fixedSize;
        xsm.serialization.msgpack.xmp_twistd.size(ref elmt);
        xsm.serialization.msgpack.xmp_twistd.serialize(bts, elmt, 0);
        xsm.serialization.msgpack.xmp_twistd.deserialize(bts, ref elmt, 0);
        ser.Read(str, ref elmt);
        ser.Write(str, elmt);
      }

      // xsm.serialization.msgpack.xmp_vector3f
      {
        var ser = new xsm.serialization.msgpack.xmp_vector3f();
        UnityEngine.Vector3 elmt = ser.DefaultValue();
        bool tmp = xsm.serialization.msgpack.xmp_vector3f.fixedSize;
        xsm.serialization.msgpack.xmp_vector3f.size(ref elmt);
        xsm.serialization.msgpack.xmp_vector3f.serialize(bts, elmt, 0);
        xsm.serialization.msgpack.xmp_vector3f.deserialize(bts, ref elmt, 0);
        ser.Read(str, ref elmt);
        ser.Write(str, elmt);
      }

      // xsm.serialization.msgpack.xmp_vector3d
      {
        var ser = new xsm.serialization.msgpack.xmp_vector3d();
        xde.unity.math.Vector3d elmt = ser.DefaultValue();
        bool tmp = xsm.serialization.msgpack.xmp_vector3d.fixedSize;
        xsm.serialization.msgpack.xmp_vector3d.size(ref elmt);
        xsm.serialization.msgpack.xmp_vector3d.serialize(bts, elmt, 0);
        xsm.serialization.msgpack.xmp_vector3d.deserialize(bts, ref elmt, 0);
        ser.Read(str, ref elmt);
        ser.Write(str, elmt);
      }

      // xsm.serialization.msgpack.xmp_vector2d
      {
        var ser = new xsm.serialization.msgpack.xmp_vector2d();
        xde.unity.math.Vector2d elmt = ser.DefaultValue();
        bool tmp = xsm.serialization.msgpack.xmp_vector2d.fixedSize;
        xsm.serialization.msgpack.xmp_vector2d.size(ref elmt);
        xsm.serialization.msgpack.xmp_vector2d.serialize(bts, elmt, 0);
        xsm.serialization.msgpack.xmp_vector2d.deserialize(bts, ref elmt, 0);
        ser.Read(str, ref elmt);
        ser.Write(str, elmt);
      }

      // xsm.serialization.msgpack.xmp_vector2f
      {
        var ser = new xsm.serialization.msgpack.xmp_vector2f();
        UnityEngine.Vector2 elmt = ser.DefaultValue();
        bool tmp = xsm.serialization.msgpack.xmp_vector2f.fixedSize;
        xsm.serialization.msgpack.xmp_vector2f.size(ref elmt);
        xsm.serialization.msgpack.xmp_vector2f.serialize(bts, elmt, 0);
        xsm.serialization.msgpack.xmp_vector2f.deserialize(bts, ref elmt, 0);
        ser.Read(str, ref elmt);
        ser.Write(str, elmt);
      }

      // xsm.serialization.msgpack.xmp_quaternionf
      {
        var ser = new xsm.serialization.msgpack.xmp_quaternionf();
        UnityEngine.Quaternion elmt = ser.DefaultValue();
        bool tmp = xsm.serialization.msgpack.xmp_quaternionf.fixedSize;
        xsm.serialization.msgpack.xmp_quaternionf.size(ref elmt);
        xsm.serialization.msgpack.xmp_quaternionf.serialize(bts, elmt, 0);
        xsm.serialization.msgpack.xmp_quaternionf.deserialize(bts, ref elmt, 0);
        ser.Read(str, ref elmt);
        ser.Write(str, elmt);
      }

      // xsm.serialization.msgpack.xmp_quaterniond
      {
        var ser = new xsm.serialization.msgpack.xmp_quaterniond();
        xde.unity.math.Quaterniond elmt = ser.DefaultValue();
        bool tmp = xsm.serialization.msgpack.xmp_quaterniond.fixedSize;
        xsm.serialization.msgpack.xmp_quaterniond.size(ref elmt);
        xsm.serialization.msgpack.xmp_quaterniond.serialize(bts, elmt, 0);
        xsm.serialization.msgpack.xmp_quaterniond.deserialize(bts, ref elmt, 0);
        ser.Read(str, ref elmt);
        ser.Write(str, elmt);
      }

      //xsm.serialization.msgpack.xmp_heterogeneous_array
      {
        var ser = new xsm.serialization.msgpack.xmp_heterogeneous_array();
        xsm.serialization.msgpack.HeterogeneousArray elmt = ser.DefaultValue();
        ser.Read(str, ref elmt);
        ser.Write(str, elmt);
      }

      //xsm.serialization.msgpack.xmp_heterogeneous_map
      {
        var ser = new xsm.serialization.msgpack.xmp_heterogeneous_map();
        xsm.serialization.msgpack.HeterogeneousMap elmt = ser.DefaultValue();
        ser.Read(str, ref elmt);
        ser.Write(str, elmt);
      }
    }
  }
}
