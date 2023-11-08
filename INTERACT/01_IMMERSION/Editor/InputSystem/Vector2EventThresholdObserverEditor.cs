using Interact.InputManagement.Events;
using InteractEditor.Immersion;
using UnityEditor;
using UnityEditor.AnimatedValues;
using UnityEngine;

namespace InteractEditor.InputManagement.Events
{
	[CustomEditor(typeof(Vector2EventThresholdObserver))]
	public class Vector2EventThresholdObserverEditor : UnityEditor.Editor
	{
		private SerializedProperty m_input;
		private SerializedProperty m_observedEvents;
		private SerializedProperty m_inputThreshold;
		private SerializedProperty m_onTriggerNorth;
		private SerializedProperty m_onTriggerSouth;
		private SerializedProperty m_onTriggerEast;
		private SerializedProperty m_onTriggerWest;
		private SerializedProperty m_onCenter;
		private SerializedProperty m_triggerMode;
		private SerializedProperty m_repeat;
		private SerializedProperty m_delayedRepeater;

		private AnimBool m_showRepeaterSettings;
		private AnimBool m_showRepeaterDetails;
		private AnimBool m_showMapping;

		private void OnEnable()
		{
			m_showRepeaterDetails = new AnimBool();
			m_showRepeaterDetails.valueChanged.AddListener(Repaint);

			m_showRepeaterSettings = new AnimBool();
			m_showRepeaterDetails.valueChanged.AddListener(Repaint);

			m_showMapping = new AnimBool();
			m_showMapping.valueChanged.AddListener(Repaint);

			m_input = serializedObject.FindProperty("m_input");
			m_observedEvents = serializedObject.FindProperty("m_observedEvents");
			m_inputThreshold = serializedObject.FindProperty("m_inputThreshold");
			m_onTriggerNorth = serializedObject.FindProperty("m_onTriggerNorth");
			m_onTriggerSouth = serializedObject.FindProperty("m_onTriggerSouth");
			m_onTriggerEast = serializedObject.FindProperty("m_onTriggerEast");
			m_onTriggerWest = serializedObject.FindProperty("m_onTriggerWest");
			m_onCenter = serializedObject.FindProperty("m_onCenter");
			m_triggerMode = serializedObject.FindProperty("m_triggerMode");
			m_repeat = serializedObject.FindProperty("m_repeat");
			m_delayedRepeater = serializedObject.FindProperty("m_delayedRepeater");
		}

		public override void OnInspectorGUI()
		{
			EditorGUILayout.PropertyField(m_observedEvents);
			EditorGUILayout.PropertyField(m_inputThreshold);
			EditorGUILayout.PropertyField(m_onTriggerNorth);
			EditorGUILayout.PropertyField(m_onTriggerSouth);
			EditorGUILayout.PropertyField(m_onTriggerEast);
			EditorGUILayout.PropertyField(m_onTriggerWest);
			EditorGUILayout.PropertyField(m_onCenter);
			EditorGUILayout.PropertyField(m_triggerMode);

			EditorGUILayout.Space();

			m_showRepeaterSettings.target = (Vector2EventThresholdObserver.TriggerMode) m_triggerMode.intValue ==
			                        Vector2EventThresholdObserver.TriggerMode.SINGLE;

			EditorGUILayout.BeginFadeGroup(m_showRepeaterSettings.faded);
			if (m_showRepeaterSettings.target)
			{
				m_showRepeaterDetails.target =
				EditorGUILayout.BeginFoldoutHeaderGroup(m_showRepeaterDetails.target, "Repeater");
			}

			if (m_showRepeaterDetails.target)
			{
				EditorGUILayout.BeginFadeGroup(m_showRepeaterDetails.faded);
				using (new EditorGUI.IndentLevelScope())
				{
					EditorGUILayout.PropertyField(m_repeat, new GUIContent("Enabled"));
					EditorGUILayout.PropertyField(m_delayedRepeater);
				}
				EditorGUILayout.EndFadeGroup();
			}

			if (m_showRepeaterSettings.target)
			{
				EditorGUILayout.EndFoldoutHeaderGroup();
			}

			EditorGUILayout.EndFadeGroup();

			m_showMapping.target = EditorGUILayout.BeginFoldoutHeaderGroup(m_showMapping.target, "Mapping");
			if (m_showMapping.target)
			{
				Vector2EventThresholdObserver l_self = (Vector2EventThresholdObserver) target;

				EditorGraph l_graph = new EditorGraph(-100, -100, 100, 100, "Threshold Mapping", 1000);

				l_graph.Draw(200, 200);

				using (new Handles.DrawingScope(Color.gray))
				{
					l_graph.DrawLine(-100, 0, 100, 0, Handles.color, 2);
					l_graph.DrawLine(0, -100, 0, 100, Handles.color, 2);
				}

				Vector2 l_graphUp = new Vector2(0, 1);
				Vector2 l_graphRight = new Vector2(1, 0);

				using (new Handles.DrawingScope(new Color(0.3f, 0.3f, 0.3f)))
				{
					PrintThresholdAngle(l_self.InputThreshold.VerticalAngle, l_graphUp, l_graph);
					PrintThresholdAngle(l_self.InputThreshold.VerticalAngle, -l_graphUp, l_graph);

					PrintThresholdAngle(l_self.InputThreshold.HorizontalAngle, l_graphRight, l_graph);
					PrintThresholdAngle(l_self.InputThreshold.HorizontalAngle, -l_graphRight, l_graph);
				}

				using (new Handles.DrawingScope(Color.gray))
				{
					DrawAngleStopThreshold(l_graph, l_self.InputThreshold.VerticalAngle,
						l_self.InputThreshold.AngularStopThreshold, l_graphUp);
					DrawAngleStopThreshold(l_graph, l_self.InputThreshold.VerticalAngle,
						l_self.InputThreshold.AngularStopThreshold, -l_graphUp);
					DrawAngleStopThreshold(l_graph, l_self.InputThreshold.HorizontalAngle,
						l_self.InputThreshold.AngularStopThreshold, l_graphRight);
					DrawAngleStopThreshold(l_graph, l_self.InputThreshold.HorizontalAngle,
						l_self.InputThreshold.AngularStopThreshold, -l_graphRight);
				}

				DrawStartStopThreshold(l_graph, l_self.InputThreshold);
				DrawDeadZone(l_graph, l_self.InputThreshold.DeadZone * 100f);
				if (Application.isPlaying)
				{
					DrawStickVector(l_graph, new Vector2(m_input.vector2Value.x * 100f, m_input.vector2Value.y * 100f));
				}

				using (new Handles.DrawingScope(Color.grey))
				{
					l_graph.DrawWireCircle(Vector2.zero, 100f, 2);
				}
			}

			serializedObject.ApplyModifiedProperties();
		}

		private void DrawAngleStopThreshold(EditorGraph p_graph, float p_startAngle, float p_threshold, Vector2 p_dir)
		{
			float l_angle = p_startAngle / 2f + p_threshold;

			Vector3 l_rotated = (Quaternion.Euler(0, 0, l_angle) * p_dir).normalized * 100f;
			Vector3 l_rotatedCounter = (Quaternion.Euler(0, 0, -l_angle) * p_dir).normalized * 100f;

			p_graph.DrawLine(0, 0, l_rotated.x, l_rotated.y, Handles.color, 2);
			p_graph.DrawLine(0, 0, l_rotatedCounter.x, l_rotatedCounter.y, Handles.color, 2);
		}

		private void DrawStartStopThreshold(EditorGraph p_graph,
																				Vector2EventThresholdObserver.AxisThreshold p_inputThreshold)
		{
			using (new Handles.DrawingScope(new Color(0.15f, 0.15f, 0.15f)))
			{
				p_graph.DrawSolidCircle(Vector2.zero, p_inputThreshold.Start * 100f, 2);
			}

			using (new Handles.DrawingScope(new Color(0.3f, 0.3f, 0.3f)))
			{
				p_graph.DrawWireCircle(Vector2.zero, p_inputThreshold.Start * 100f, 2);
			}

			using (new Handles.DrawingScope(new Color(0.12f, 0.12f, 0.12f)))
			{
				p_graph.DrawSolidCircle(Vector2.zero, p_inputThreshold.Stop * 100f, 2);
			}

			using (new Handles.DrawingScope(new Color(0.3f, 0.3f, 0.3f)))
			{
				p_graph.DrawWireCircle(Vector2.zero, p_inputThreshold.Stop * 100f, 2);
			}
		}

		private void DrawDeadZone(EditorGraph p_graph, float p_deadZone)
		{
			using (new Handles.DrawingScope(Color.black))
			{
				p_graph.DrawSolidCircle(Vector2.zero, p_deadZone);
			}

			using (new Handles.DrawingScope(new Color(0.3f, 0.3f, 0.3f)))
			{
				p_graph.DrawWireCircle(Vector2.zero, p_deadZone);
			}
		}

		private void DrawStickVector(EditorGraph p_graph, Vector2 p_stick)
		{
			using (new Handles.DrawingScope(Color.green))
			{
				Handles.DrawSolidDisc(p_graph.UnitToGraph(p_stick.x, p_stick.y), Vector3.forward, 3.0f);
				p_graph.DrawLine(0, 0, p_stick.x, p_stick.y, Handles.color, 2);
			}
		}

		private void PrintThresholdAngle(float p_angle, Vector2 p_dir, EditorGraph p_graph)
		{
			Vector3 l_rotated = (Quaternion.Euler(0, 0, p_angle / 2f) * p_dir).normalized * 100f;
			Vector3 l_rotatedCounter = (Quaternion.Euler(0, 0, -(p_angle / 2f)) * p_dir).normalized * 100f;

			p_graph.DrawSolidArc(Vector3.zero, p_dir.normalized * 100f, p_angle);
			p_graph.DrawLine(0, 0, l_rotated.x, l_rotated.y, Handles.color, 2);
			p_graph.DrawLine(0, 0, l_rotatedCounter.x, l_rotatedCounter.y, Handles.color, 2);
		}
	}
}