using Interact.Immersion.Navigation;
using UnityEngine;
using UnityEditor;
using UnityEditor.AnimatedValues;

namespace InteractEditor.Immersion.Navigation
{
	[CustomEditor(typeof(TeleportController))]
	public class TeleportControllerEditor : UnityEditor.Editor
	{
		private SerializedProperty m_user;
		private SerializedProperty m_head;

		private SerializedProperty m_cursors;
		private SerializedProperty m_trajectory;
		private SerializedProperty m_rotationStep;
		private SerializedProperty m_obstacleLayer;
		private SerializedProperty m_walkableLayer;

		private SerializedProperty m_hidePointsOfInterest;

		private SerializedProperty m_onTeleport;

		private AnimBool m_showCallbacks;

		private void OnEnable()
		{
			m_user = serializedObject.FindProperty("m_user");
			m_head = serializedObject.FindProperty("m_head");

			m_cursors = serializedObject.FindProperty("m_cursors");

			m_trajectory = serializedObject.FindProperty("m_trajectory");
			m_rotationStep = serializedObject.FindProperty("m_rotationStep");

			m_obstacleLayer = serializedObject.FindProperty("m_obstacleLayer");
			m_walkableLayer = serializedObject.FindProperty("m_walkableLayer");

			m_hidePointsOfInterest = serializedObject.FindProperty("m_hidePointsOfInterest");

			m_onTeleport = serializedObject.FindProperty("m_onTeleport");

			m_showCallbacks = new AnimBool(false);
			m_showCallbacks.valueChanged.AddListener(Repaint);
		}

		public override void OnInspectorGUI()
		{
			GUI.enabled = false;
			EditorGUILayout.ObjectField("Script:", MonoScript.FromMonoBehaviour((MonoBehaviour) target),
										GetType(), false);
			GUI.enabled = true;
			//base.OnInspectorGUI();
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

			EditorGUILayout.Space(10);
			EditorGUILayout.LabelField("Settings", EditorStyles.boldLabel);
			EditorGUILayout.PropertyField(m_trajectory);

			EditorGUILayout.Space(10);
			EditorGUILayout.LabelField("Layers", EditorStyles.boldLabel);
			EditorGUILayout.PropertyField(m_walkableLayer);
			EditorGUILayout.PropertyField(m_obstacleLayer);

			EditorGUILayout.Space(10);
			EditorGUILayout.PropertyField(m_hidePointsOfInterest, new GUIContent("Hide points of interest when teleport is disabled"));

			EditorGUILayout.Space();
			m_showCallbacks.target = EditorGUILayout.BeginFoldoutHeaderGroup(m_showCallbacks.target, "Callbacks");
			if (EditorGUILayout.BeginFadeGroup(m_showCallbacks.faded))
			{
				EditorGUILayout.PropertyField(m_onTeleport);
			}
			EditorGUILayout.EndFadeGroup();
		}
	}
}
