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
  class Basic_core_beam
  {
    [UnityEngine.Scripting.Preserve]
    static void ForceRegistrationOfMethod()
    {
      // The factory must be registered.
      xde.client.core.PluginFactory tmp2 = new xde.client.core.PluginFactory();

      // Register all the types
      System.IO.FileStream str = new System.IO.FileStream("/C/tmp/", System.IO.FileMode.Create);
      byte[] bts = new byte[0];
      //xde_types.core.xde_beam_configuration
      {
        var ser = new xde_types.core.xde_beam_configuration();
        xde_types.core.beam_configuration elmt = xde_types.core.xde_beam_configuration.default_value();
        bool tmp = xde_types.core.xde_beam_configuration.fixedSize;
        xde_types.core.xde_beam_configuration.size(ref elmt);
        xde_types.core.xde_beam_configuration.serialize(bts, elmt, 0);
        xde_types.core.xde_beam_configuration.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_beam_stiffness_computation_mode
      {
        var ser = new xde_types.core.xde_beam_stiffness_computation_mode();
        xde_types.core.beam_stiffness_computation_mode elmt = xde_types.core.xde_beam_stiffness_computation_mode.default_value();
        bool tmp = xde_types.core.xde_beam_stiffness_computation_mode.fixedSize;
        xde_types.core.xde_beam_stiffness_computation_mode.size(ref elmt);
        xde_types.core.xde_beam_stiffness_computation_mode.serialize(bts, elmt, 0);
        xde_types.core.xde_beam_stiffness_computation_mode.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_beam_attach_mode
      {
        var ser = new xde_types.core.xde_beam_attach_mode();
        xde_types.core.beam_attach_mode elmt = xde_types.core.xde_beam_attach_mode.default_value();
        bool tmp = xde_types.core.xde_beam_attach_mode.fixedSize;
        xde_types.core.xde_beam_attach_mode.size(ref elmt);
        xde_types.core.xde_beam_attach_mode.serialize(bts, elmt, 0);
        xde_types.core.xde_beam_attach_mode.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      
      //xde_types.core.xde_beam_material
      {
        var ser = new xde_types.core.xde_beam_material();
        xde_types.core.beam_material elmt = xde_types.core.xde_beam_material.default_value();
        bool tmp = xde_types.core.xde_beam_material.fixedSize;
        xde_types.core.xde_beam_material.size(ref elmt);
        xde_types.core.xde_beam_material.serialize(bts, elmt, 0);
        xde_types.core.xde_beam_material.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_beam_state
      {
        var ser = new xde_types.core.xde_beam_state();
        xde_types.core.beam_state elmt = xde_types.core.xde_beam_state.default_value();
        bool tmp = xde_types.core.xde_beam_state.fixedSize;
        xde_types.core.xde_beam_state.size(ref elmt);
        xde_types.core.xde_beam_state.serialize(bts, elmt, 0);
        xde_types.core.xde_beam_state.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_beam_state_complete
      {
        var ser = new xde_types.core.xde_beam_state_complete();
        xde_types.core.beam_state_complete elmt = xde_types.core.xde_beam_state_complete.default_value();
        bool tmp = xde_types.core.xde_beam_state_complete.fixedSize;
        xde_types.core.xde_beam_state_complete.size(ref elmt);
        xde_types.core.xde_beam_state_complete.serialize(bts, elmt, 0);
        xde_types.core.xde_beam_state_complete.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_beam_composition
      {
        var ser = new xde_types.core.xde_beam_composition();
        xde_types.core.beam_composition elmt = xde_types.core.xde_beam_composition.default_value();
        bool tmp = xde_types.core.xde_beam_composition.fixedSize;
        xde_types.core.xde_beam_composition.size(ref elmt);
        xde_types.core.xde_beam_composition.serialize(bts, elmt, 0);
        xde_types.core.xde_beam_composition.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_beam_compression
      {
        var ser = new xde_types.core.xde_beam_compression();
        xde_types.core.beam_compression elmt = xde_types.core.xde_beam_compression.default_value();
        bool tmp = xde_types.core.xde_beam_compression.fixedSize;
        xde_types.core.xde_beam_compression.size(ref elmt);
        xde_types.core.xde_beam_compression.serialize(bts, elmt, 0);
        xde_types.core.xde_beam_compression.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_beam_positions
      {
        var ser = new xde_types.core.xde_beam_positions();
        xde_types.core.beam_positions elmt = xde_types.core.xde_beam_positions.default_value();
        bool tmp = xde_types.core.xde_beam_positions.fixedSize;
        xde_types.core.xde_beam_positions.size(ref elmt);
        xde_types.core.xde_beam_positions.serialize(bts, elmt, 0);
        xde_types.core.xde_beam_positions.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_beam_velocities
      {
        var ser = new xde_types.core.xde_beam_velocities();
        xde_types.core.beam_velocities elmt = xde_types.core.xde_beam_velocities.default_value();
        bool tmp = xde_types.core.xde_beam_velocities.fixedSize;
        xde_types.core.xde_beam_velocities.size(ref elmt);
        xde_types.core.xde_beam_velocities.serialize(bts, elmt, 0);
        xde_types.core.xde_beam_velocities.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_leak_A
      {
        var ser = new xde_types.core.xde_leak_A();
        xde_types.core.leak_A elmt = xde_types.core.xde_leak_A.default_value();
        bool tmp = xde_types.core.xde_leak_A.fixedSize;
        xde_types.core.xde_leak_A.size(ref elmt);
        xde_types.core.xde_leak_A.serialize(bts, elmt, 0);
        xde_types.core.xde_leak_A.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_leak_B
      {
        var ser = new xde_types.core.xde_leak_B();
        xde_types.core.leak_B elmt = xde_types.core.xde_leak_B.default_value();
        bool tmp = xde_types.core.xde_leak_B.fixedSize;
        xde_types.core.xde_leak_B.size(ref elmt);
        xde_types.core.xde_leak_B.serialize(bts, elmt, 0);
        xde_types.core.xde_leak_B.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_leak_C
      {
        var ser = new xde_types.core.xde_leak_C();
        xde_types.core.leak_C elmt = xde_types.core.xde_leak_C.default_value();
        bool tmp = xde_types.core.xde_leak_C.fixedSize;
        xde_types.core.xde_leak_C.size(ref elmt);
        xde_types.core.xde_leak_C.serialize(bts, elmt, 0);
        xde_types.core.xde_leak_C.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }

    }
  };
}
#endif // ENABLE_IL2CPP// ===========================
// GENERATED CODE, DO NOT EDIT
// generated at 2023-08-09 16:55:04.863000
// from template 'cs/modules_components_uwp_cs.tpl'
// ===========================
#if ENABLE_IL2CPP

// https://docs.unity3d.com/Manual/ScriptingRestrictions.html 
// To work around an AOT issue like this, we force the compiler to generate the proper code.
namespace XdeEngine.IL2CPP
{
  class Basic_core_collision
  {
    [UnityEngine.Scripting.Preserve]
    static void ForceRegistrationOfMethod()
    {
      // The factory must be registered.
      xde.client.core.PluginFactory tmp2 = new xde.client.core.PluginFactory();

      // Register all the types
      System.IO.FileStream str = new System.IO.FileStream("/C/tmp/", System.IO.FileMode.Create);
      byte[] bts = new byte[0];
      //xde_types.core.xde_contact_normal_law
      {
        var ser = new xde_types.core.xde_contact_normal_law();
        xde_types.core.contact_normal_law elmt = xde_types.core.xde_contact_normal_law.default_value();
        bool tmp = xde_types.core.xde_contact_normal_law.fixedSize;
        xde_types.core.xde_contact_normal_law.size(ref elmt);
        xde_types.core.xde_contact_normal_law.serialize(bts, elmt, 0);
        xde_types.core.xde_contact_normal_law.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_monitoring_type
      {
        var ser = new xde_types.core.xde_monitoring_type();
        xde_types.core.monitoring_type elmt = xde_types.core.xde_monitoring_type.default_value();
        bool tmp = xde_types.core.xde_monitoring_type.fixedSize;
        xde_types.core.xde_monitoring_type.size(ref elmt);
        xde_types.core.xde_monitoring_type.serialize(bts, elmt, 0);
        xde_types.core.xde_monitoring_type.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_monitoring_mode
      {
        var ser = new xde_types.core.xde_monitoring_mode();
        xde_types.core.monitoring_mode elmt = xde_types.core.xde_monitoring_mode.default_value();
        bool tmp = xde_types.core.xde_monitoring_mode.fixedSize;
        xde_types.core.xde_monitoring_mode.size(ref elmt);
        xde_types.core.xde_monitoring_mode.serialize(bts, elmt, 0);
        xde_types.core.xde_monitoring_mode.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_collision_mode
      {
        var ser = new xde_types.core.xde_collision_mode();
        xde_types.core.collision_mode elmt = xde_types.core.xde_collision_mode.default_value();
        bool tmp = xde_types.core.xde_collision_mode.fixedSize;
        xde_types.core.xde_collision_mode.size(ref elmt);
        xde_types.core.xde_collision_mode.serialize(bts, elmt, 0);
        xde_types.core.xde_collision_mode.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_intersect_query_type
      {
        var ser = new xde_types.core.xde_intersect_query_type();
        xde_types.core.intersect_query_type elmt = xde_types.core.xde_intersect_query_type.default_value();
        bool tmp = xde_types.core.xde_intersect_query_type.fixedSize;
        xde_types.core.xde_intersect_query_type.size(ref elmt);
        xde_types.core.xde_intersect_query_type.serialize(bts, elmt, 0);
        xde_types.core.xde_intersect_query_type.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_contact_friction_law
      {
        var ser = new xde_types.core.xde_contact_friction_law();
        xde_types.core.contact_friction_law elmt = xde_types.core.xde_contact_friction_law.default_value();
        bool tmp = xde_types.core.xde_contact_friction_law.fixedSize;
        xde_types.core.xde_contact_friction_law.size(ref elmt);
        xde_types.core.xde_contact_friction_law.serialize(bts, elmt, 0);
        xde_types.core.xde_contact_friction_law.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_monitoring_filter
      {
        var ser = new xde_types.core.xde_monitoring_filter();
        xde_types.core.monitoring_filter elmt = xde_types.core.xde_monitoring_filter.default_value();
        bool tmp = xde_types.core.xde_monitoring_filter.fixedSize;
        xde_types.core.xde_monitoring_filter.size(ref elmt);
        xde_types.core.xde_monitoring_filter.serialize(bts, elmt, 0);
        xde_types.core.xde_monitoring_filter.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      
      //xde_types.core.xde_interference_event
      {
        var ser = new xde_types.core.xde_interference_event();
        xde_types.core.interference_event elmt = xde_types.core.xde_interference_event.default_value();
        bool tmp = xde_types.core.xde_interference_event.fixedSize;
        xde_types.core.xde_interference_event.size(ref elmt);
        xde_types.core.xde_interference_event.serialize(bts, elmt, 0);
        xde_types.core.xde_interference_event.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_interference_list
      {
        var ser = new xde_types.core.xde_interference_list();
        xde_types.core.interference_list elmt = xde_types.core.xde_interference_list.default_value();
        bool tmp = xde_types.core.xde_interference_list.fixedSize;
        xde_types.core.xde_interference_list.size(ref elmt);
        xde_types.core.xde_interference_list.serialize(bts, elmt, 0);
        xde_types.core.xde_interference_list.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_layer_interaction
      {
        var ser = new xde_types.core.xde_layer_interaction();
        xde_types.core.layer_interaction elmt = xde_types.core.xde_layer_interaction.default_value();
        bool tmp = xde_types.core.xde_layer_interaction.fixedSize;
        xde_types.core.xde_layer_interaction.size(ref elmt);
        xde_types.core.xde_layer_interaction.serialize(bts, elmt, 0);
        xde_types.core.xde_layer_interaction.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_layer_interaction_list
      {
        var ser = new xde_types.core.xde_layer_interaction_list();
        xde_types.core.layer_interaction_list elmt = xde_types.core.xde_layer_interaction_list.default_value();
        bool tmp = xde_types.core.xde_layer_interaction_list.fixedSize;
        xde_types.core.xde_layer_interaction_list.size(ref elmt);
        xde_types.core.xde_layer_interaction_list.serialize(bts, elmt, 0);
        xde_types.core.xde_layer_interaction_list.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_contact_point
      {
        var ser = new xde_types.core.xde_contact_point();
        xde_types.core.contact_point elmt = xde_types.core.xde_contact_point.default_value();
        bool tmp = xde_types.core.xde_contact_point.fixedSize;
        xde_types.core.xde_contact_point.size(ref elmt);
        xde_types.core.xde_contact_point.serialize(bts, elmt, 0);
        xde_types.core.xde_contact_point.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_contact_bodypair
      {
        var ser = new xde_types.core.xde_contact_bodypair();
        xde_types.core.contact_bodypair elmt = xde_types.core.xde_contact_bodypair.default_value();
        bool tmp = xde_types.core.xde_contact_bodypair.fixedSize;
        xde_types.core.xde_contact_bodypair.size(ref elmt);
        xde_types.core.xde_contact_bodypair.serialize(bts, elmt, 0);
        xde_types.core.xde_contact_bodypair.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_contact_layerpair
      {
        var ser = new xde_types.core.xde_contact_layerpair();
        xde_types.core.contact_layerpair elmt = xde_types.core.xde_contact_layerpair.default_value();
        bool tmp = xde_types.core.xde_contact_layerpair.fixedSize;
        xde_types.core.xde_contact_layerpair.size(ref elmt);
        xde_types.core.xde_contact_layerpair.serialize(bts, elmt, 0);
        xde_types.core.xde_contact_layerpair.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_contact_events
      {
        var ser = new xde_types.core.xde_contact_events();
        xde_types.core.contact_events elmt = xde_types.core.xde_contact_events.default_value();
        bool tmp = xde_types.core.xde_contact_events.fixedSize;
        xde_types.core.xde_contact_events.size(ref elmt);
        xde_types.core.xde_contact_events.serialize(bts, elmt, 0);
        xde_types.core.xde_contact_events.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_distance
      {
        var ser = new xde_types.core.xde_distance();
        xde_types.core.distance elmt = xde_types.core.xde_distance.default_value();
        bool tmp = xde_types.core.xde_distance.fixedSize;
        xde_types.core.xde_distance.size(ref elmt);
        xde_types.core.xde_distance.serialize(bts, elmt, 0);
        xde_types.core.xde_distance.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_monitored_elements
      {
        var ser = new xde_types.core.xde_monitored_elements();
        xde_types.core.monitored_elements elmt = xde_types.core.xde_monitored_elements.default_value();
        bool tmp = xde_types.core.xde_monitored_elements.fixedSize;
        xde_types.core.xde_monitored_elements.size(ref elmt);
        xde_types.core.xde_monitored_elements.serialize(bts, elmt, 0);
        xde_types.core.xde_monitored_elements.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_advanced_contact_law
      {
        var ser = new xde_types.core.xde_advanced_contact_law();
        xde_types.core.advanced_contact_law elmt = xde_types.core.xde_advanced_contact_law.default_value();
        bool tmp = xde_types.core.xde_advanced_contact_law.fixedSize;
        xde_types.core.xde_advanced_contact_law.size(ref elmt);
        xde_types.core.xde_advanced_contact_law.serialize(bts, elmt, 0);
        xde_types.core.xde_advanced_contact_law.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_contact_law_vector
      {
        var ser = new xde_types.core.xde_contact_law_vector();
        xde_types.core.contact_law_vector elmt = xde_types.core.xde_contact_law_vector.default_value();
        bool tmp = xde_types.core.xde_contact_law_vector.fixedSize;
        xde_types.core.xde_contact_law_vector.size(ref elmt);
        xde_types.core.xde_contact_law_vector.serialize(bts, elmt, 0);
        xde_types.core.xde_contact_law_vector.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_group_interaction
      {
        var ser = new xde_types.core.xde_group_interaction();
        xde_types.core.group_interaction elmt = xde_types.core.xde_group_interaction.default_value();
        bool tmp = xde_types.core.xde_group_interaction.fixedSize;
        xde_types.core.xde_group_interaction.size(ref elmt);
        xde_types.core.xde_group_interaction.serialize(bts, elmt, 0);
        xde_types.core.xde_group_interaction.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_contact_grouppair
      {
        var ser = new xde_types.core.xde_contact_grouppair();
        xde_types.core.contact_grouppair elmt = xde_types.core.xde_contact_grouppair.default_value();
        bool tmp = xde_types.core.xde_contact_grouppair.fixedSize;
        xde_types.core.xde_contact_grouppair.size(ref elmt);
        xde_types.core.xde_contact_grouppair.serialize(bts, elmt, 0);
        xde_types.core.xde_contact_grouppair.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_group_contact_events
      {
        var ser = new xde_types.core.xde_group_contact_events();
        xde_types.core.group_contact_events elmt = xde_types.core.xde_group_contact_events.default_value();
        bool tmp = xde_types.core.xde_group_contact_events.fixedSize;
        xde_types.core.xde_group_contact_events.size(ref elmt);
        xde_types.core.xde_group_contact_events.serialize(bts, elmt, 0);
        xde_types.core.xde_group_contact_events.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_collision_rule_data
      {
        var ser = new xde_types.core.xde_collision_rule_data();
        xde_types.core.collision_rule_data elmt = xde_types.core.xde_collision_rule_data.default_value();
        bool tmp = xde_types.core.xde_collision_rule_data.fixedSize;
        xde_types.core.xde_collision_rule_data.size(ref elmt);
        xde_types.core.xde_collision_rule_data.serialize(bts, elmt, 0);
        xde_types.core.xde_collision_rule_data.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_group_changes
      {
        var ser = new xde_types.core.xde_group_changes();
        xde_types.core.group_changes elmt = xde_types.core.xde_group_changes.default_value();
        bool tmp = xde_types.core.xde_group_changes.fixedSize;
        xde_types.core.xde_group_changes.size(ref elmt);
        xde_types.core.xde_group_changes.serialize(bts, elmt, 0);
        xde_types.core.xde_group_changes.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }

    }
  };
}
#endif // ENABLE_IL2CPP// ===========================
// GENERATED CODE, DO NOT EDIT
// generated at 2023-08-09 16:55:04.863000
// from template 'cs/modules_components_uwp_cs.tpl'
// ===========================
#if ENABLE_IL2CPP

// https://docs.unity3d.com/Manual/ScriptingRestrictions.html 
// To work around an AOT issue like this, we force the compiler to generate the proper code.
namespace XdeEngine.IL2CPP
{
  class Basic_core_couplings
  {
    [UnityEngine.Scripting.Preserve]
    static void ForceRegistrationOfMethod()
    {
      // The factory must be registered.
      xde.client.core.PluginFactory tmp2 = new xde.client.core.PluginFactory();

      // Register all the types
      System.IO.FileStream str = new System.IO.FileStream("/C/tmp/", System.IO.FileMode.Create);
      byte[] bts = new byte[0];
      

    }
  };
}
#endif // ENABLE_IL2CPP// ===========================
// GENERATED CODE, DO NOT EDIT
// generated at 2023-08-09 16:55:04.863000
// from template 'cs/modules_components_uwp_cs.tpl'
// ===========================
#if ENABLE_IL2CPP

// https://docs.unity3d.com/Manual/ScriptingRestrictions.html 
// To work around an AOT issue like this, we force the compiler to generate the proper code.
namespace XdeEngine.IL2CPP
{
  class Basic_core_devices
  {
    [UnityEngine.Scripting.Preserve]
    static void ForceRegistrationOfMethod()
    {
      // The factory must be registered.
      xde.client.core.PluginFactory tmp2 = new xde.client.core.PluginFactory();

      // Register all the types
      System.IO.FileStream str = new System.IO.FileStream("/C/tmp/", System.IO.FileMode.Create);
      byte[] bts = new byte[0];
      //xde_types.core.xde_grasp_offset_mode
      {
        var ser = new xde_types.core.xde_grasp_offset_mode();
        xde_types.core.grasp_offset_mode elmt = xde_types.core.xde_grasp_offset_mode.default_value();
        bool tmp = xde_types.core.xde_grasp_offset_mode.fixedSize;
        xde_types.core.xde_grasp_offset_mode.size(ref elmt);
        xde_types.core.xde_grasp_offset_mode.serialize(bts, elmt, 0);
        xde_types.core.xde_grasp_offset_mode.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      
      //xde_types.core.xde_pbm_state
      {
        var ser = new xde_types.core.xde_pbm_state();
        xde_types.core.pbm_state elmt = xde_types.core.xde_pbm_state.default_value();
        bool tmp = xde_types.core.xde_pbm_state.fixedSize;
        xde_types.core.xde_pbm_state.size(ref elmt);
        xde_types.core.xde_pbm_state.serialize(bts, elmt, 0);
        xde_types.core.xde_pbm_state.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_spacemouse_state
      {
        var ser = new xde_types.core.xde_spacemouse_state();
        xde_types.core.spacemouse_state elmt = xde_types.core.xde_spacemouse_state.default_value();
        bool tmp = xde_types.core.xde_spacemouse_state.fixedSize;
        xde_types.core.xde_spacemouse_state.size(ref elmt);
        xde_types.core.xde_spacemouse_state.serialize(bts, elmt, 0);
        xde_types.core.xde_spacemouse_state.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }

    }
  };
}
#endif // ENABLE_IL2CPP// ===========================
// GENERATED CODE, DO NOT EDIT
// generated at 2023-08-09 16:55:04.863000
// from template 'cs/modules_components_uwp_cs.tpl'
// ===========================
#if ENABLE_IL2CPP

// https://docs.unity3d.com/Manual/ScriptingRestrictions.html 
// To work around an AOT issue like this, we force the compiler to generate the proper code.
namespace XdeEngine.IL2CPP
{
  class Basic_core_fewire
  {
    [UnityEngine.Scripting.Preserve]
    static void ForceRegistrationOfMethod()
    {
      // The factory must be registered.
      xde.client.core.PluginFactory tmp2 = new xde.client.core.PluginFactory();

      // Register all the types
      System.IO.FileStream str = new System.IO.FileStream("/C/tmp/", System.IO.FileMode.Create);
      byte[] bts = new byte[0];
      //xde_types.core.xde_wire_configuration
      {
        var ser = new xde_types.core.xde_wire_configuration();
        xde_types.core.wire_configuration elmt = xde_types.core.xde_wire_configuration.default_value();
        bool tmp = xde_types.core.xde_wire_configuration.fixedSize;
        xde_types.core.xde_wire_configuration.size(ref elmt);
        xde_types.core.xde_wire_configuration.serialize(bts, elmt, 0);
        xde_types.core.xde_wire_configuration.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_wire_stiffness_computation_mode
      {
        var ser = new xde_types.core.xde_wire_stiffness_computation_mode();
        xde_types.core.wire_stiffness_computation_mode elmt = xde_types.core.xde_wire_stiffness_computation_mode.default_value();
        bool tmp = xde_types.core.xde_wire_stiffness_computation_mode.fixedSize;
        xde_types.core.xde_wire_stiffness_computation_mode.size(ref elmt);
        xde_types.core.xde_wire_stiffness_computation_mode.serialize(bts, elmt, 0);
        xde_types.core.xde_wire_stiffness_computation_mode.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      
      //xde_types.core.xde_wire_state
      {
        var ser = new xde_types.core.xde_wire_state();
        xde_types.core.wire_state elmt = xde_types.core.xde_wire_state.default_value();
        bool tmp = xde_types.core.xde_wire_state.fixedSize;
        xde_types.core.xde_wire_state.size(ref elmt);
        xde_types.core.xde_wire_state.serialize(bts, elmt, 0);
        xde_types.core.xde_wire_state.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_wire_state_complete
      {
        var ser = new xde_types.core.xde_wire_state_complete();
        xde_types.core.wire_state_complete elmt = xde_types.core.xde_wire_state_complete.default_value();
        bool tmp = xde_types.core.xde_wire_state_complete.fixedSize;
        xde_types.core.xde_wire_state_complete.size(ref elmt);
        xde_types.core.xde_wire_state_complete.serialize(bts, elmt, 0);
        xde_types.core.xde_wire_state_complete.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_wire_compression
      {
        var ser = new xde_types.core.xde_wire_compression();
        xde_types.core.wire_compression elmt = xde_types.core.xde_wire_compression.default_value();
        bool tmp = xde_types.core.xde_wire_compression.fixedSize;
        xde_types.core.xde_wire_compression.size(ref elmt);
        xde_types.core.xde_wire_compression.serialize(bts, elmt, 0);
        xde_types.core.xde_wire_compression.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_wire_positions
      {
        var ser = new xde_types.core.xde_wire_positions();
        xde_types.core.wire_positions elmt = xde_types.core.xde_wire_positions.default_value();
        bool tmp = xde_types.core.xde_wire_positions.fixedSize;
        xde_types.core.xde_wire_positions.size(ref elmt);
        xde_types.core.xde_wire_positions.serialize(bts, elmt, 0);
        xde_types.core.xde_wire_positions.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_wire_velocities
      {
        var ser = new xde_types.core.xde_wire_velocities();
        xde_types.core.wire_velocities elmt = xde_types.core.xde_wire_velocities.default_value();
        bool tmp = xde_types.core.xde_wire_velocities.fixedSize;
        xde_types.core.xde_wire_velocities.size(ref elmt);
        xde_types.core.xde_wire_velocities.serialize(bts, elmt, 0);
        xde_types.core.xde_wire_velocities.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }

    }
  };
}
#endif // ENABLE_IL2CPP// ===========================
// GENERATED CODE, DO NOT EDIT
// generated at 2023-08-09 16:55:04.863000
// from template 'cs/modules_components_uwp_cs.tpl'
// ===========================
#if ENABLE_IL2CPP

// https://docs.unity3d.com/Manual/ScriptingRestrictions.html 
// To work around an AOT issue like this, we force the compiler to generate the proper code.
namespace XdeEngine.IL2CPP
{
  class Basic_core_joints
  {
    [UnityEngine.Scripting.Preserve]
    static void ForceRegistrationOfMethod()
    {
      // The factory must be registered.
      xde.client.core.PluginFactory tmp2 = new xde.client.core.PluginFactory();

      // Register all the types
      System.IO.FileStream str = new System.IO.FileStream("/C/tmp/", System.IO.FileMode.Create);
      byte[] bts = new byte[0];
      //xde_types.core.xde_coupling_mode
      {
        var ser = new xde_types.core.xde_coupling_mode();
        xde_types.core.coupling_mode elmt = xde_types.core.xde_coupling_mode.default_value();
        bool tmp = xde_types.core.xde_coupling_mode.fixedSize;
        xde_types.core.xde_coupling_mode.size(ref elmt);
        xde_types.core.xde_coupling_mode.serialize(bts, elmt, 0);
        xde_types.core.xde_coupling_mode.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_mapped_joint_type
      {
        var ser = new xde_types.core.xde_mapped_joint_type();
        xde_types.core.mapped_joint_type elmt = xde_types.core.xde_mapped_joint_type.default_value();
        bool tmp = xde_types.core.xde_mapped_joint_type.fixedSize;
        xde_types.core.xde_mapped_joint_type.size(ref elmt);
        xde_types.core.xde_mapped_joint_type.serialize(bts, elmt, 0);
        xde_types.core.xde_mapped_joint_type.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      
      //xde_types.core.xde_limit_data
      {
        var ser = new xde_types.core.xde_limit_data();
        xde_types.core.limit_data elmt = xde_types.core.xde_limit_data.default_value();
        bool tmp = xde_types.core.xde_limit_data.fixedSize;
        xde_types.core.xde_limit_data.size(ref elmt);
        xde_types.core.xde_limit_data.serialize(bts, elmt, 0);
        xde_types.core.xde_limit_data.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_joint_state
      {
        var ser = new xde_types.core.xde_joint_state();
        xde_types.core.joint_state elmt = xde_types.core.xde_joint_state.default_value();
        bool tmp = xde_types.core.xde_joint_state.fixedSize;
        xde_types.core.xde_joint_state.size(ref elmt);
        xde_types.core.xde_joint_state.serialize(bts, elmt, 0);
        xde_types.core.xde_joint_state.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_unit_joint_state
      {
        var ser = new xde_types.core.xde_unit_joint_state();
        xde_types.core.unit_joint_state elmt = xde_types.core.xde_unit_joint_state.default_value();
        bool tmp = xde_types.core.xde_unit_joint_state.fixedSize;
        xde_types.core.xde_unit_joint_state.size(ref elmt);
        xde_types.core.xde_unit_joint_state.serialize(bts, elmt, 0);
        xde_types.core.xde_unit_joint_state.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_double_unit_joint_state
      {
        var ser = new xde_types.core.xde_double_unit_joint_state();
        xde_types.core.double_unit_joint_state elmt = xde_types.core.xde_double_unit_joint_state.default_value();
        bool tmp = xde_types.core.xde_double_unit_joint_state.fixedSize;
        xde_types.core.xde_double_unit_joint_state.size(ref elmt);
        xde_types.core.xde_double_unit_joint_state.serialize(bts, elmt, 0);
        xde_types.core.xde_double_unit_joint_state.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_ball_joint_state
      {
        var ser = new xde_types.core.xde_ball_joint_state();
        xde_types.core.ball_joint_state elmt = xde_types.core.xde_ball_joint_state.default_value();
        bool tmp = xde_types.core.xde_ball_joint_state.fixedSize;
        xde_types.core.xde_ball_joint_state.size(ref elmt);
        xde_types.core.xde_ball_joint_state.serialize(bts, elmt, 0);
        xde_types.core.xde_ball_joint_state.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_dry_friction_state
      {
        var ser = new xde_types.core.xde_dry_friction_state();
        xde_types.core.dry_friction_state elmt = xde_types.core.xde_dry_friction_state.default_value();
        bool tmp = xde_types.core.xde_dry_friction_state.fixedSize;
        xde_types.core.xde_dry_friction_state.size(ref elmt);
        xde_types.core.xde_dry_friction_state.serialize(bts, elmt, 0);
        xde_types.core.xde_dry_friction_state.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_unit_joint_PD_state
      {
        var ser = new xde_types.core.xde_unit_joint_PD_state();
        xde_types.core.unit_joint_PD_state elmt = xde_types.core.xde_unit_joint_PD_state.default_value();
        bool tmp = xde_types.core.xde_unit_joint_PD_state.fixedSize;
        xde_types.core.xde_unit_joint_PD_state.size(ref elmt);
        xde_types.core.xde_unit_joint_PD_state.serialize(bts, elmt, 0);
        xde_types.core.xde_unit_joint_PD_state.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_unit_joint_PID_state
      {
        var ser = new xde_types.core.xde_unit_joint_PID_state();
        xde_types.core.unit_joint_PID_state elmt = xde_types.core.xde_unit_joint_PID_state.default_value();
        bool tmp = xde_types.core.xde_unit_joint_PID_state.fixedSize;
        xde_types.core.xde_unit_joint_PID_state.size(ref elmt);
        xde_types.core.xde_unit_joint_PID_state.serialize(bts, elmt, 0);
        xde_types.core.xde_unit_joint_PID_state.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_planar_joint_state
      {
        var ser = new xde_types.core.xde_planar_joint_state();
        xde_types.core.planar_joint_state elmt = xde_types.core.xde_planar_joint_state.default_value();
        bool tmp = xde_types.core.xde_planar_joint_state.fixedSize;
        xde_types.core.xde_planar_joint_state.size(ref elmt);
        xde_types.core.xde_planar_joint_state.serialize(bts, elmt, 0);
        xde_types.core.xde_planar_joint_state.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }

    }
  };
}
#endif // ENABLE_IL2CPP// ===========================
// GENERATED CODE, DO NOT EDIT
// generated at 2023-08-09 16:55:04.863000
// from template 'cs/modules_components_uwp_cs.tpl'
// ===========================
#if ENABLE_IL2CPP

// https://docs.unity3d.com/Manual/ScriptingRestrictions.html 
// To work around an AOT issue like this, we force the compiler to generate the proper code.
namespace XdeEngine.IL2CPP
{
  class Basic_core_raycasting
  {
    [UnityEngine.Scripting.Preserve]
    static void ForceRegistrationOfMethod()
    {
      // The factory must be registered.
      xde.client.core.PluginFactory tmp2 = new xde.client.core.PluginFactory();

      // Register all the types
      System.IO.FileStream str = new System.IO.FileStream("/C/tmp/", System.IO.FileMode.Create);
      byte[] bts = new byte[0];
      

    }
  };
}
#endif // ENABLE_IL2CPP// ===========================
// GENERATED CODE, DO NOT EDIT
// generated at 2023-08-09 16:55:04.863000
// from template 'cs/modules_components_uwp_cs.tpl'
// ===========================
#if ENABLE_IL2CPP

// https://docs.unity3d.com/Manual/ScriptingRestrictions.html 
// To work around an AOT issue like this, we force the compiler to generate the proper code.
namespace XdeEngine.IL2CPP
{
  class Basic_core_record
  {
    [UnityEngine.Scripting.Preserve]
    static void ForceRegistrationOfMethod()
    {
      // The factory must be registered.
      xde.client.core.PluginFactory tmp2 = new xde.client.core.PluginFactory();

      // Register all the types
      System.IO.FileStream str = new System.IO.FileStream("/C/tmp/", System.IO.FileMode.Create);
      byte[] bts = new byte[0];
      

    }
  };
}
#endif // ENABLE_IL2CPP// ===========================
// GENERATED CODE, DO NOT EDIT
// generated at 2023-08-09 16:55:04.863000
// from template 'cs/modules_components_uwp_cs.tpl'
// ===========================
#if ENABLE_IL2CPP

// https://docs.unity3d.com/Manual/ScriptingRestrictions.html 
// To work around an AOT issue like this, we force the compiler to generate the proper code.
namespace XdeEngine.IL2CPP
{
  class Basic_core_rigidbody_ext
  {
    [UnityEngine.Scripting.Preserve]
    static void ForceRegistrationOfMethod()
    {
      // The factory must be registered.
      xde.client.core.PluginFactory tmp2 = new xde.client.core.PluginFactory();

      // Register all the types
      System.IO.FileStream str = new System.IO.FileStream("/C/tmp/", System.IO.FileMode.Create);
      byte[] bts = new byte[0];
      

    }
  };
}
#endif // ENABLE_IL2CPP// ===========================
// GENERATED CODE, DO NOT EDIT
// generated at 2023-08-09 16:55:04.863000
// from template 'cs/modules_components_uwp_cs.tpl'
// ===========================
#if ENABLE_IL2CPP

// https://docs.unity3d.com/Manual/ScriptingRestrictions.html 
// To work around an AOT issue like this, we force the compiler to generate the proper code.
namespace XdeEngine.IL2CPP
{
  class Basic_core_scene
  {
    [UnityEngine.Scripting.Preserve]
    static void ForceRegistrationOfMethod()
    {
      // The factory must be registered.
      xde.client.core.PluginFactory tmp2 = new xde.client.core.PluginFactory();

      // Register all the types
      System.IO.FileStream str = new System.IO.FileStream("/C/tmp/", System.IO.FileMode.Create);
      byte[] bts = new byte[0];
      //xde_types.core.xde_persistence_mode
      {
        var ser = new xde_types.core.xde_persistence_mode();
        xde_types.core.persistence_mode elmt = xde_types.core.xde_persistence_mode.default_value();
        bool tmp = xde_types.core.xde_persistence_mode.fixedSize;
        xde_types.core.xde_persistence_mode.size(ref elmt);
        xde_types.core.xde_persistence_mode.serialize(bts, elmt, 0);
        xde_types.core.xde_persistence_mode.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_collision_solver
      {
        var ser = new xde_types.core.xde_collision_solver();
        xde_types.core.collision_solver elmt = xde_types.core.xde_collision_solver.default_value();
        bool tmp = xde_types.core.xde_collision_solver.fixedSize;
        xde_types.core.xde_collision_solver.size(ref elmt);
        xde_types.core.xde_collision_solver.serialize(bts, elmt, 0);
        xde_types.core.xde_collision_solver.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_gvm_evolution
      {
        var ser = new xde_types.core.xde_gvm_evolution();
        xde_types.core.gvm_evolution elmt = xde_types.core.xde_gvm_evolution.default_value();
        bool tmp = xde_types.core.xde_gvm_evolution.fixedSize;
        xde_types.core.xde_gvm_evolution.size(ref elmt);
        xde_types.core.xde_gvm_evolution.serialize(bts, elmt, 0);
        xde_types.core.xde_gvm_evolution.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_contact_type
      {
        var ser = new xde_types.core.xde_contact_type();
        xde_types.core.contact_type elmt = xde_types.core.xde_contact_type.default_value();
        bool tmp = xde_types.core.xde_contact_type.fixedSize;
        xde_types.core.xde_contact_type.size(ref elmt);
        xde_types.core.xde_contact_type.serialize(bts, elmt, 0);
        xde_types.core.xde_contact_type.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_performance_timer_data
      {
        var ser = new xde_types.core.xde_performance_timer_data();
        xde_types.core.performance_timer_data elmt = xde_types.core.xde_performance_timer_data.default_value();
        bool tmp = xde_types.core.xde_performance_timer_data.fixedSize;
        xde_types.core.xde_performance_timer_data.size(ref elmt);
        xde_types.core.xde_performance_timer_data.serialize(bts, elmt, 0);
        xde_types.core.xde_performance_timer_data.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_limiter_mode
      {
        var ser = new xde_types.core.xde_limiter_mode();
        xde_types.core.limiter_mode elmt = xde_types.core.xde_limiter_mode.default_value();
        bool tmp = xde_types.core.xde_limiter_mode.fixedSize;
        xde_types.core.xde_limiter_mode.size(ref elmt);
        xde_types.core.xde_limiter_mode.serialize(bts, elmt, 0);
        xde_types.core.xde_limiter_mode.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_gvm_direct_solver
      {
        var ser = new xde_types.core.xde_gvm_direct_solver();
        xde_types.core.gvm_direct_solver elmt = xde_types.core.xde_gvm_direct_solver.default_value();
        bool tmp = xde_types.core.xde_gvm_direct_solver.fixedSize;
        xde_types.core.xde_gvm_direct_solver.size(ref elmt);
        xde_types.core.xde_gvm_direct_solver.serialize(bts, elmt, 0);
        xde_types.core.xde_gvm_direct_solver.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_contact_restitution_mode
      {
        var ser = new xde_types.core.xde_contact_restitution_mode();
        xde_types.core.contact_restitution_mode elmt = xde_types.core.xde_contact_restitution_mode.default_value();
        bool tmp = xde_types.core.xde_contact_restitution_mode.fixedSize;
        xde_types.core.xde_contact_restitution_mode.size(ref elmt);
        xde_types.core.xde_contact_restitution_mode.serialize(bts, elmt, 0);
        xde_types.core.xde_contact_restitution_mode.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      
      //xde_types.core.xde_contact_law
      {
        var ser = new xde_types.core.xde_contact_law();
        xde_types.core.contact_law elmt = xde_types.core.xde_contact_law.default_value();
        bool tmp = xde_types.core.xde_contact_law.fixedSize;
        xde_types.core.xde_contact_law.size(ref elmt);
        xde_types.core.xde_contact_law.serialize(bts, elmt, 0);
        xde_types.core.xde_contact_law.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      //xde_types.core.xde_rigidbody_state
      {
        var ser = new xde_types.core.xde_rigidbody_state();
        xde_types.core.rigidbody_state elmt = xde_types.core.xde_rigidbody_state.default_value();
        bool tmp = xde_types.core.xde_rigidbody_state.fixedSize;
        xde_types.core.xde_rigidbody_state.size(ref elmt);
        xde_types.core.xde_rigidbody_state.serialize(bts, elmt, 0);
        xde_types.core.xde_rigidbody_state.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }

    }
  };
}
#endif // ENABLE_IL2CPP// ===========================
// GENERATED CODE, DO NOT EDIT
// generated at 2023-08-09 16:55:04.863000
// from template 'cs/modules_components_uwp_cs.tpl'
// ===========================
#if ENABLE_IL2CPP

// https://docs.unity3d.com/Manual/ScriptingRestrictions.html 
// To work around an AOT issue like this, we force the compiler to generate the proper code.
namespace XdeEngine.IL2CPP
{
  class Basic_core_skeleton
  {
    [UnityEngine.Scripting.Preserve]
    static void ForceRegistrationOfMethod()
    {
      // The factory must be registered.
      xde.client.core.PluginFactory tmp2 = new xde.client.core.PluginFactory();

      // Register all the types
      System.IO.FileStream str = new System.IO.FileStream("/C/tmp/", System.IO.FileMode.Create);
      byte[] bts = new byte[0];
      
      //xde_types.core.xde_skeleton_tracker_state
      {
        var ser = new xde_types.core.xde_skeleton_tracker_state();
        xde_types.core.skeleton_tracker_state elmt = xde_types.core.xde_skeleton_tracker_state.default_value();
        bool tmp = xde_types.core.xde_skeleton_tracker_state.fixedSize;
        xde_types.core.xde_skeleton_tracker_state.size(ref elmt);
        xde_types.core.xde_skeleton_tracker_state.serialize(bts, elmt, 0);
        xde_types.core.xde_skeleton_tracker_state.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }

    }
  };
}
#endif // ENABLE_IL2CPP// ===========================
// GENERATED CODE, DO NOT EDIT
// generated at 2023-08-09 16:55:04.863000
// from template 'cs/modules_components_uwp_cs.tpl'
// ===========================
#if ENABLE_IL2CPP

// https://docs.unity3d.com/Manual/ScriptingRestrictions.html 
// To work around an AOT issue like this, we force the compiler to generate the proper code.
namespace XdeEngine.IL2CPP
{
  class Basic_core_sweptVolume
  {
    [UnityEngine.Scripting.Preserve]
    static void ForceRegistrationOfMethod()
    {
      // The factory must be registered.
      xde.client.core.PluginFactory tmp2 = new xde.client.core.PluginFactory();

      // Register all the types
      System.IO.FileStream str = new System.IO.FileStream("/C/tmp/", System.IO.FileMode.Create);
      byte[] bts = new byte[0];
      

    }
  };
}
#endif // ENABLE_IL2CPP// ===========================
// GENERATED CODE, DO NOT EDIT
// generated at 2023-08-09 16:55:04.863000
// from template 'cs/modules_components_uwp_cs.tpl'
// ===========================
#if ENABLE_IL2CPP

// https://docs.unity3d.com/Manual/ScriptingRestrictions.html 
// To work around an AOT issue like this, we force the compiler to generate the proper code.
namespace XdeEngine.IL2CPP
{
  class Basic_core_variables
  {
    [UnityEngine.Scripting.Preserve]
    static void ForceRegistrationOfMethod()
    {
      // The factory must be registered.
      xde.client.core.PluginFactory tmp2 = new xde.client.core.PluginFactory();

      // Register all the types
      System.IO.FileStream str = new System.IO.FileStream("/C/tmp/", System.IO.FileMode.Create);
      byte[] bts = new byte[0];
      //xde_types.core.xde_variable_type
      {
        var ser = new xde_types.core.xde_variable_type();
        xde_types.core.variable_type elmt = xde_types.core.xde_variable_type.default_value();
        bool tmp = xde_types.core.xde_variable_type.fixedSize;
        xde_types.core.xde_variable_type.size(ref elmt);
        xde_types.core.xde_variable_type.serialize(bts, elmt, 0);
        xde_types.core.xde_variable_type.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }
      

    }
  };
}
#endif // ENABLE_IL2CPP// ===========================
// GENERATED CODE, DO NOT EDIT
// generated at 2023-08-09 16:55:04.863000
// from template 'cs/modules_components_uwp_cs.tpl'
// ===========================
#if ENABLE_IL2CPP

// https://docs.unity3d.com/Manual/ScriptingRestrictions.html 
// To work around an AOT issue like this, we force the compiler to generate the proper code.
namespace XdeEngine.IL2CPP
{
  class Basic_core_webservice
  {
    [UnityEngine.Scripting.Preserve]
    static void ForceRegistrationOfMethod()
    {
      // The factory must be registered.
      xde.client.core.PluginFactory tmp2 = new xde.client.core.PluginFactory();

      // Register all the types
      System.IO.FileStream str = new System.IO.FileStream("/C/tmp/", System.IO.FileMode.Create);
      byte[] bts = new byte[0];
      

    }
  };
}
#endif // ENABLE_IL2CPP// ===========================
// GENERATED CODE, DO NOT EDIT
// generated at 2023-08-09 16:55:04.863000
// from template 'cs/modules_components_uwp_cs.tpl'
// ===========================
#if ENABLE_IL2CPP

// https://docs.unity3d.com/Manual/ScriptingRestrictions.html 
// To work around an AOT issue like this, we force the compiler to generate the proper code.
namespace XdeEngine.IL2CPP
{
  class Basic_core_welder
  {
    [UnityEngine.Scripting.Preserve]
    static void ForceRegistrationOfMethod()
    {
      // The factory must be registered.
      xde.client.core.PluginFactory tmp2 = new xde.client.core.PluginFactory();

      // Register all the types
      System.IO.FileStream str = new System.IO.FileStream("/C/tmp/", System.IO.FileMode.Create);
      byte[] bts = new byte[0];
      
      //xde_types.core.xde_weld_joint_state
      {
        var ser = new xde_types.core.xde_weld_joint_state();
        xde_types.core.weld_joint_state elmt = xde_types.core.xde_weld_joint_state.default_value();
        bool tmp = xde_types.core.xde_weld_joint_state.fixedSize;
        xde_types.core.xde_weld_joint_state.size(ref elmt);
        xde_types.core.xde_weld_joint_state.serialize(bts, elmt, 0);
        xde_types.core.xde_weld_joint_state.deserialize(bts, ref elmt, 0);
        ser.Write(str, elmt);
        ser.Read(str, ref elmt);
      }

    }
  };
}
#endif // ENABLE_IL2CPP