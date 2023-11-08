using Interact.Immersion.VRMenu;
using UnityEditor;

namespace InteractEditor.Immersion.VRMenu
{
	[CustomEditor(typeof(CalibrateHeightVRMenuItem))]
	public class CalibrateHeightVRMenuItemEditor : VRMenuItemEditor
	{
		private SerializedProperty m_avatarIk;

		protected override void OnEnable()
		{
			base.OnEnable();

			m_avatarIk = serializedObject.FindProperty("m_avatarIk");
		}

		public override void OnInspectorGUI()
		{
			base.OnInspectorGUI();

			EditorGUILayout.PropertyField(m_avatarIk);

			serializedObject.ApplyModifiedProperties();
		}
	}
}