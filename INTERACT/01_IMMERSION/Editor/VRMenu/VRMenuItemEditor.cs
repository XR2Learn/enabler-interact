using System;
using System.Collections.Generic;
using System.Linq;
using Interact.Immersion.VRMenu;
using Interact.Immersion.Modes;
using UnityEditor;

namespace InteractEditor.Immersion.VRMenu
{
	[CustomEditor(typeof(VRMenuItem))]
	[CanEditMultipleObjects]
	public class VRMenuItemEditor : Editor
	{
		private List<string> m_modeNames;
		private List<Type> m_modeTypes;
		private int m_modeCount;

		private SerializedProperty m_vrMenu;
		private SerializedProperty m_modeController;

		protected virtual void OnEnable()
		{
			m_vrMenu = serializedObject.FindProperty("m_vrMenu");
			m_modeController = serializedObject.FindProperty("m_modeController");

			IEnumerable<Type> l_modes = AppDomain.CurrentDomain.GetAssemblies()
																					 .SelectMany(p_asm => p_asm.GetTypes())
																					 .Where(p_type => p_type.IsSubclassOf(typeof(ModeController)));

			m_modeTypes = l_modes.ToList();
			m_modeNames = m_modeTypes.Select(p_mode => p_mode.Name).ToList();

			m_modeCount = m_modeTypes.Count;
		}

		private void DrawModeController()
		{
			VRMenuItem l_self = target as VRMenuItem;

			int currentModeIndex = m_modeNames.Count - 1;
			if (l_self.m_modeController != null)
			{
				currentModeIndex = m_modeNames.IndexOf(l_self.m_modeController.GetType().Name);
			}

			using (EditorGUI.ChangeCheckScope l_changeCheck = new EditorGUI.ChangeCheckScope())
			{
				int l_selectedIndex = EditorGUILayout.Popup("Mode Controller", currentModeIndex, m_modeNames.ToArray());

				if (l_changeCheck.changed)
				{
					l_self.m_modeController = Activator.CreateInstance(m_modeTypes[l_selectedIndex]) as ModeController;
				}
			}
		}

		public override void OnInspectorGUI()
		{
			EditorGUILayout.PropertyField(m_vrMenu);
			DrawModeController();

			serializedObject.ApplyModifiedProperties();
		}
	}
}