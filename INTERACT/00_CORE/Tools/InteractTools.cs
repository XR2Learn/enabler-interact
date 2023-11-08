using System;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
using Object = UnityEngine.Object;

namespace Interact
{
	public static class InteractTools
	{
		public static void SaveAsset(Object p_object)
		{
#if UNITY_EDITOR
			EditorUtility.SetDirty(p_object);
			AssetDatabase.SaveAssets();
#endif
		}

		public static void RegisterCreatedObjectUndo(Object p_object, string p_name)
		{
#if UNITY_EDITOR
			Undo.RegisterCreatedObjectUndo(p_object, p_name);
#endif
		}

		public static Component UndoableAddComponent(GameObject p_gameObject, Type p_type)
		{
#if UNITY_EDITOR
			return Undo.AddComponent(p_gameObject, p_type);
#else
			return p_gameObject.AddComponent(p_type);
#endif
		}

		public static void ClearProgressBar()
		{
#if UNITY_EDITOR
			EditorUtility.ClearProgressBar();
#endif //UNITY_EDITOR
		}

		public static void DisplayDialog(string p_title, string p_msg, string p_ok)
		{
#if UNITY_EDITOR
			EditorUtility.DisplayDialog(p_title, p_msg, p_ok);
#endif
		}

		public static void DisplayProgressBar(float p_value)
		{
#if UNITY_EDITOR
			EditorUtility.DisplayCancelableProgressBar("[Cable generation]", "Generating cable ",
					p_value + 0.05f);
#endif
		}
	}
}