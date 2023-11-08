using UnityEditor;
using UnityEngine;
using Interact.Ergonomics;

namespace InteractEditor.Ergonomics
{
	[CustomEditor(typeof(ManikinManager))]
	public class HumanManagerEditor : Editor
	{
		SerializedProperty m_defaultAvatarProp;

		public void OnEnable()
		{
			m_defaultAvatarProp = serializedObject.FindProperty("m_defaultAvatar");
		}

		public override void OnInspectorGUI()
		{
			ManikinManager l_manikinManager = target as ManikinManager;
			GameObject currentGameObject = l_manikinManager.gameObject;

			serializedObject.Update();
			EditorGUI.BeginChangeCheck();

			EditorGUILayout.PropertyField(m_defaultAvatarProp);

			DrawPropertiesExcluding(serializedObject, "m_defaultAvatar");

			if (EditorGUI.EndChangeCheck())
			{
				serializedObject.ApplyModifiedProperties();
				l_manikinManager.DefaultAvatar = (ManikinManager.AvatarModes)m_defaultAvatarProp.enumValueIndex;
			}
		}
	}
}