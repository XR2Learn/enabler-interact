using Interact.Immersion.Navigation;
using UnityEditor;
using UnityEngine;

namespace InteractEditor.Immersion.Navigation
{
	[CustomEditor(typeof(WalkController))]
	public class WalkControllerEditor : UnityEditor.Editor
	{
		private SerializedProperty m_user;
		private SerializedProperty m_head;

		private SerializedProperty m_leftStick;
		private SerializedProperty m_rightStick;
		private SerializedProperty m_amplitude;
		private SerializedProperty m_cursors;

		private SerializedProperty m_arrowPrefab;
		private SerializedProperty m_rotationStep;

		private static bool s_showController = false;

		protected virtual void OnEnable()
		{
			m_user = serializedObject.FindProperty("m_user");
			m_head = serializedObject.FindProperty("m_head");

			m_cursors = serializedObject.FindProperty("m_cursors");
			m_leftStick = serializedObject.FindProperty("m_leftStick");
			m_rightStick = serializedObject.FindProperty("m_rightStick");
			m_amplitude = serializedObject.FindProperty("m_amplitude");

			m_arrowPrefab = serializedObject.FindProperty("m_arrowPrefab");
			m_rotationStep = serializedObject.FindProperty("m_rotationStep");
		}

  	public override void OnInspectorGUI()
  	{
		GUI.enabled = false;
		EditorGUILayout.ObjectField("Script:", MonoScript.FromMonoBehaviour((MonoBehaviour) target),
									GetType(), false);
		GUI.enabled = true;
  		serializedObject.Update();
  		DrawComponents();
  		serializedObject.ApplyModifiedProperties();
  	}

  	private void DrawComponents()
		{
			EditorGUILayout.Space(10);
			EditorGUILayout.PropertyField(m_user);
			EditorGUILayout.PropertyField(m_head);
  		EditorGUILayout.Space(10);
			EditorGUILayout.PropertyField(m_cursors);

			s_showController = EditorGUILayout.BeginFoldoutHeaderGroup(s_showController, "Controller");
			if (s_showController)
			{
				EditorGUILayout.PropertyField(m_leftStick);
				EditorGUILayout.PropertyField(m_rightStick);
				EditorGUILayout.PropertyField(m_amplitude);
			}
			EditorGUILayout.EndFoldoutHeaderGroup();

			EditorGUILayout.Space(10);

			EditorGUILayout.LabelField("Settings", EditorStyles.boldLabel);
			EditorGUILayout.PropertyField(m_arrowPrefab);
			EditorGUILayout.PropertyField(m_rotationStep);
			EditorGUILayout.Space(10);

		}

  }

}
