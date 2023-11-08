using Interact.Ergonomics;
using InteractEditor.Immersion.VRMenu;
using UnityEditor;

namespace InteractEditor.Ergonomics
{
	[CustomEditor(typeof(CalibrateVRMenuItem))]
	public class CalibrateVRMenuItemEditor : VRMenuItemEditor
	{
		private SerializedProperty m_manikinManager;
		private SerializedProperty m_avatarIk;
		private SerializedProperty m_ergoCalibration;

		protected override void OnEnable()
		{
			base.OnEnable();

			m_avatarIk = serializedObject.FindProperty("m_avatarIk");
			m_ergoCalibration = serializedObject.FindProperty("m_ergoCalibration");
		}

		public override void OnInspectorGUI()
		{
			base.OnInspectorGUI();

			EditorGUILayout.PropertyField(m_avatarIk);
			EditorGUILayout.PropertyField(m_ergoCalibration);

			serializedObject.ApplyModifiedProperties();
		}
	}
}