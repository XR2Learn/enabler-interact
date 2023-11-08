using System;
using Interact.Immersion.Tools;
using UnityEditor;
using UnityEngine;

namespace InteractEditor.Immersion.Tools
{
	[CustomEditor(typeof(TrackingMeasure))]
	public class TrackingMeasureEditor : UnityEditor.Editor
	{
		private bool m_lengthFoldoutHeaderGroup = true;
		private bool m_showAnchorFoldoutHeaderGroup = true;

		private bool m_isPickingStart = false;
		private bool m_isPickingEnd = false;

		private Ray m_ray;

		private Vector3 m_lastHitLocation;

		private bool m_isEditingStartAnchor = false;
		private bool m_isEditingEndAnchor = false;

		private static GUIStyle s_toggleButtonStyleNormal = null;
		private static GUIStyle s_toggleButtonStyleToggled = null;

		public override void OnInspectorGUI()
		{
			if (s_toggleButtonStyleNormal == null)
			{
				s_toggleButtonStyleNormal = GUI.skin.GetStyle("Button");
				s_toggleButtonStyleToggled = new GUIStyle(s_toggleButtonStyleNormal);
				s_toggleButtonStyleToggled.normal = s_toggleButtonStyleToggled.active;
			}

			TrackingMeasure l_self = target as TrackingMeasure;

			if (!l_self)
			{
				throw new NullReferenceException(nameof(l_self));
			}

			l_self.m_name = EditorGUILayout.TextField("Name", l_self.m_name).Trim();

			l_self.LookAtCamera = EditorGUILayout
				.Toggle(new GUIContent("Look At Camera", "Should the measure face the camera at all times during runtime?"),
								l_self.LookAtCamera);

			EditorGUILayout.Separator();

			m_showAnchorFoldoutHeaderGroup = EditorGUILayout.BeginFoldoutHeaderGroup(m_showAnchorFoldoutHeaderGroup, "Anchor");
			if (m_showAnchorFoldoutHeaderGroup)
			{
				EditorGUI.indentLevel++;

				using (new EditorGUILayout.HorizontalScope())
				{
					using (EditorGUI.ChangeCheckScope l_check = new EditorGUI.ChangeCheckScope())
					{
						l_self.StartObject =
							EditorGUILayout.ObjectField("Start Object", l_self.StartObject, typeof(GameObject), true)
								as GameObject;

						if (l_check.changed && l_self.StartObject)
						{
							l_self.StartAnchor = CreateAnchor(l_self.StartObject);
						}
					}

					if (GUILayout.Button("Pick"))
						m_isPickingStart = true;
				}

				if (l_self.StartAnchor)
				{
						// Prevent numerical instability by comparing if the value has changed before assigning it.
						Vector3 l_oldStartAnchor = l_self.StartAnchor.transform.position;
						Vector3 l_newStartAnchor = EditorGUILayout.Vector3Field(new GUIContent("Anchor Position", "Relative to the measured objet's position"), l_oldStartAnchor);
						if (l_oldStartAnchor != l_newStartAnchor)
						{
							l_self.StartAnchor.transform.position = l_newStartAnchor;
						}

						using (new EditorGUILayout.HorizontalScope())
						{
							EditorGUILayout.LabelField("Edit Anchor");
							m_isEditingStartAnchor = GUILayout.Toggle(m_isEditingStartAnchor, "Edit",
																												m_isEditingStartAnchor
																													? s_toggleButtonStyleToggled
																													: s_toggleButtonStyleNormal);
						}
				}

				if (!l_self.StartObject)
				{
					EditorGUILayout.HelpBox("No starting point set. Measure cannot be displayed!", MessageType.Error);
				}

				EditorGUILayout.Separator();

				using (new EditorGUILayout.HorizontalScope())
				{
					using (EditorGUI.ChangeCheckScope l_check = new EditorGUI.ChangeCheckScope())
					{
						l_self.EndObject =
							EditorGUILayout.ObjectField("End Object", l_self.EndObject, typeof(GameObject), true)
								as GameObject;

						if (l_check.changed && l_self.EndObject)
						{
							l_self.EndAnchor = CreateAnchor(l_self.EndObject);
						}
					}

					if (GUILayout.Button("Pick"))
						m_isPickingEnd = true;
				}

				if (l_self.EndAnchor)
				{
					// Prevent numerical instability by comparing if the value has changed before assigning it.
					Vector3 l_oldEndAnchor = l_self.EndAnchor.transform.position;
					Vector3 l_newEndAnchor =
						EditorGUILayout.Vector3Field(new GUIContent("Anchor Position", "Relative to the measured object's position"),
																				 l_oldEndAnchor);
					if (l_oldEndAnchor != l_newEndAnchor)
					{
						l_self.EndAnchor.transform.position = l_newEndAnchor;
					}

					using (new EditorGUILayout.HorizontalScope())
					{
						EditorGUILayout.LabelField("Edit Anchor");
						m_isEditingEndAnchor = GUILayout.Toggle(m_isEditingEndAnchor, "Edit",
																										m_isEditingEndAnchor
																											? s_toggleButtonStyleToggled
																											: s_toggleButtonStyleNormal);
					}
				}

				if (!l_self.EndObject)
				{
					EditorGUILayout.HelpBox("No ending point set. Measure cannot be displayed!", MessageType.Error);
				}

				EditorGUI.indentLevel--;
			}
			EditorGUILayout.EndFoldoutHeaderGroup();

			EditorGUILayout.Separator();

			m_lengthFoldoutHeaderGroup = EditorGUILayout.BeginFoldoutHeaderGroup(m_lengthFoldoutHeaderGroup, "Length");
			if (m_lengthFoldoutHeaderGroup)
			{
				EditorGUI.indentLevel++;

				serializedObject.Update();

				EditorGUILayout.PropertyField(serializedObject.FindProperty("m_onLengthChanged"));

				serializedObject.ApplyModifiedProperties();

				EditorGUI.indentLevel--;
			}
			EditorGUILayout.EndFoldoutHeaderGroup();
		}

		private void OnSceneGUI()
		{
			TrackingMeasure l_self = target as TrackingMeasure;

			if (!l_self)
			{
				throw new NullReferenceException(nameof(l_self));
			}

			if (m_isEditingStartAnchor)
			{
				Vector3 l_oldPoint = l_self.StartAnchor.transform.position;
				Vector3 l_newPoint = Handles.PositionHandle(l_oldPoint, Quaternion.identity);

				if (l_oldPoint != l_newPoint)
				{
					Undo.RecordObject(l_self.StartAnchor.transform, "Move Anchor");
					l_self.StartAnchor.transform.position = l_newPoint;
				}
			}

			if (m_isEditingEndAnchor)
			{
				Vector3 l_oldPoint = l_self.EndAnchor.transform.position;
				Vector3 l_newPoint = Handles.PositionHandle(l_oldPoint, Quaternion.identity);

				if (l_oldPoint != l_newPoint)
				{
					Undo.RecordObject(l_self.EndAnchor.transform, "Move Anchor");
					l_self.EndAnchor.transform.position = l_newPoint;
				}
			}

			if (!m_isPickingStart && !m_isPickingEnd)
			{
				return;
			}

			//Intercepting mouse clicks
			if (Event.current.type == EventType.Layout)
			{
				HandleUtility.AddDefaultControl(0);
			}

			if (Event.current.type == EventType.MouseMove)
			{
				m_ray = HandleUtility.GUIPointToWorldRay(Event.current.mousePosition);
				if (UniversalRaycast.Raycast(m_ray, out UniversalRaycastHit l_raycastHit))
				{
					m_lastHitLocation = Snap.GetSnapPoint(l_raycastHit, null, SceneView.currentDrawingSceneView.camera)?.m_point ?? l_raycastHit.m_point;
				}
			}

			if (Event.current.type == EventType.Repaint)
			{
				using (new Handles.DrawingScope(Color.yellow))
				{
					Handles.DrawSolidDisc(m_lastHitLocation, SceneView.currentDrawingSceneView.camera.transform.forward,
																HandleUtility.GetHandleSize(m_lastHitLocation) * 0.04f);
				}
			}

			if (Event.current.type == EventType.MouseDown && Event.current.button == 0)
			{
				if (UniversalRaycast.Raycast(m_ray, out UniversalRaycastHit l_raycastHit))
				{
					Vector3 l_snapPoint = Snap.GetSnapPoint(l_raycastHit, null, SceneView.currentDrawingSceneView.camera)?.m_point ?? l_raycastHit.m_point;

					GameObject l_gameObject = l_raycastHit.m_transform.gameObject;
					Vector3 l_offset = l_raycastHit.m_transform.InverseTransformPoint(l_snapPoint);
					GameObject l_anchor = CreateAnchor(l_gameObject);

					l_anchor.transform.localPosition = l_offset;

					if (m_isPickingStart)
					{
						l_self.StartObject = l_gameObject;
						l_self.StartAnchor = l_anchor;
					}
					else if (m_isPickingEnd)
					{
						l_self.EndObject = l_gameObject;
						l_self.EndAnchor = l_anchor;
					}

					m_isPickingStart = false;
					m_isPickingEnd = false;
				}
			}
		}

		private GameObject CreateAnchor(GameObject p_target)
		{
			GameObject l_anchor = new GameObject
			{
				name = "Measure Anchor",
				transform =
				{
					parent = p_target.transform,
					localPosition = Vector3.zero,
				},
			};

			return l_anchor;
		}
	}
}
