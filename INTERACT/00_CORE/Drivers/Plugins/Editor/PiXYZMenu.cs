using System;

#if INTERACT_PIXYZ_PACKAGE
using UnityEngine.PixyzPlugin4Unity.Lod;
using UnityEditor.PixyzCommons.Extensions;
using UnityEditor.PixyzPlugin4Unity.Import;
using UnityEditor.PixyzPlugin4Unity.RuleEngine;
using UnityEditor.PixyzPlugin4Unity.UI.Import;
#elif PIXYZ_2020_1_OR_NEWER
using Pixyz.Commons.Extensions.Editor;
using Pixyz.ImportSDK;
using Pixyz.LODTools;
using Pixyz.Plugin4Unity;
using Pixyz.Plugin4Unity.EditorWindows;
using Pixyz.RuleEngine.Editor;
#endif //PIXYZ_2020_1_OR_NEWER

using UnityEditor;
using UnityEngine;

namespace Interact.PiXYZ
{
	public static class PiXYZMenu
	{
		[MenuItem("INTERACT/Import/CAD Model", false, 5)]
		public static void ImportCAD()
		{
#if INTERACT_PIXYZ_PACKAGE
		string l_selectedFile = string.Empty;

		try
		{
			l_selectedFile =
				EditorUtility.OpenFilePanelWithFilters("Import CAD", EditorApplication.applicationPath,
													   Formats.SupportedFormatsForFileBrowser);
		}
		catch (Exception l_exception)
		{
			Debug.LogError(l_exception);
		}

		if (string.IsNullOrEmpty(l_selectedFile))
			return;

		if (!Formats.IsFileSupported(l_selectedFile))
		{
			Debug.LogError("Unsupported file format");
			return;
		}

		LodsGenerationSettings l_lodsSettings = new LodsGenerationSettings()
		{
			lods = new LodGenerationSettings[2],
		};

		l_lodsSettings.lods[0] = new LodGenerationSettings()
		{
			quality = LodQuality.HIGH,
			threshold = 0.01f
		};

		l_lodsSettings.lods[1] = new LodGenerationSettings()
		{
			quality = LodQuality.CULLED,
			threshold = 0f
		};

		ImportWindow.ImportSettings.shader = Shader.Find("LS/Standard Triplanar with Cut");
		ImportWindow.ImportSettings.hasLODs = true;
		ImportWindow.ImportSettings.stitchPatches = true;
		ImportWindow.ImportSettings.lodsMode = LodGroupPlacement.LEAVES;
		ImportWindow.ImportSettings.qualities = l_lodsSettings;
		CoreImportWindow.Open(l_selectedFile);
		#if PIXYZ_RULE_ENGINE
		EditorWindow.GetWindow<CoreImportWindow>().RuleSet =
 AssetDatabase.LoadAssetAtPath<RuleSet>("Assets/INTERACT/00_CORE/Resources/PixyzRuleSet/CAD_IMPORT.asset");
		#endif
#elif PIXYZ_2020_1_OR_NEWER
		string l_selectedFile = string.Empty;

		try
		{
			l_selectedFile = EditorExtensions.SelectFile(Formats.SupportedFormatsForFileBrowser);
		}
		catch (Exception l_exception)
		{
			Debug.LogError(l_exception);
		}

		if (string.IsNullOrEmpty(l_selectedFile))
			return;

		if (!Formats.IsFileSupported(l_selectedFile))
		{
			Debug.LogError("Unsupported file format");
			return;
		}

		LodsGenerationSettings l_lodsSettings = new LodsGenerationSettings()
		{
			lods = new LodGenerationSettings[2],
		};

		l_lodsSettings.lods[0] = new LodGenerationSettings()
		{
			quality = LodQuality.HIGH,
			threshold = 0.01f
		};

		l_lodsSettings.lods[1] = new LodGenerationSettings()
		{
			quality = LodQuality.CULLED,
			threshold = 0f
		};

		ImportWindow.ImportSettings.shader = Shader.Find("LS/Standard Triplanar with Cut");
		ImportWindow.ImportSettings.hasLODs = true;
#if PIXYZ_2021_1_OR_NEWER
		ImportWindow.ImportSettings.stitchPatches = true;
#else
		ImportWindow.ImportSettings.mergeFinalLevel = true;
#endif
		ImportWindow.ImportSettings.lodsMode = LodGroupPlacement.LEAVES;
		ImportWindow.ImportSettings.qualities = l_lodsSettings;
		CoreImportWindow.Open(l_selectedFile);
		ImportWindow.GetWindow<CoreImportWindow>().RuleSet =
		AssetDatabase.LoadAssetAtPath<RuleSet>("Assets/INTERACT/00_CORE/Resources/PixyzRuleSet/CAD_IMPORT.asset");
#else
			EditorUtility.DisplayDialog("PiXYZ not installed",
																	"PiXYZ is not installed in your project. Please import the pixyz plugins to load CAD with INTERACT",
																	"Ok");
#endif
		}

		[MenuItem("INTERACT/Import/2D Layout", false, 5)]
		public static void ImportDrawing()
		{
#if INTERACT_PIXYZ_PACKAGE
		//string extensions = "Point Cloud files; *.dwg; *.dxf";
		string l_selectedFile = string.Empty;

		try
		{
			l_selectedFile =
				EditorUtility.OpenFilePanelWithFilters("Import Drawing", Application.dataPath, new[] { "AutoCAD files", "dwg,dxf" });
		}
		catch (Exception l_exception)
		{
			Debug.LogError(l_exception);
		}

		if (!string.IsNullOrEmpty(l_selectedFile))
		{
			ImportWindow.ImportSettings.importLines = true;
			ImportWindow.ImportSettings.isZUp = true;
			ImportWindow.ImportSettings.hasLODs = false;
			ImportWindow.ImportSettings.shader = null;

			CoreImportWindow.Open(l_selectedFile);
		}
#elif PIXYZ_2020_1_OR_NEWER
		//string extensions = "Point Cloud files; *.dwg; *.dxf";
		string l_selectedFile = string.Empty;

		try
		{
			l_selectedFile = EditorExtensions.SelectFile(new string[]{"AutoCAD files", "dwg,dxf"});
		}
		catch (Exception l_exception)
		{
			Debug.LogError(l_exception);
		}

		if (!string.IsNullOrEmpty(l_selectedFile))
		{
			//l_window.ImportCADDrawing(l_selectedFile);

			ImportWindow.ImportSettings.importLines = true;
			ImportWindow.ImportSettings.isZUp = true;
			ImportWindow.ImportSettings.hasLODs = false;
			ImportWindow.ImportSettings.shader = null;

      CoreImportWindow.Open(l_selectedFile);
		}
#else
			EditorUtility.DisplayDialog("PiXYZ not installed",
																	"PiXYZ is not installed in your project. Please import the pixyz plugins to load 2D layout with INTERACT",
																	"Ok");
#endif
		}
	}
}