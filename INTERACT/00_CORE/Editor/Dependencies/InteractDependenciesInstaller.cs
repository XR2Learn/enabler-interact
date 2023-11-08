using System.IO;
using System.Linq;
using System.Threading.Tasks;
using UnityEditor;
using UnityEditor.PackageManager;
using UnityEditor.PackageManager.Requests;
using UnityEngine;

namespace InteractEditor.Dependencies
{
	// This does not use Interact.Core as a dependency as it is used to install Interact.Core dependencies!
	// Which means any code in Interact.Core will not run until the dependencies are installed.
	internal class InteractDependenciesInstaller
	{
		[InitializeOnLoadMethod]
		private static void InitializeOnLoad()
		{
			AssetDatabase.importPackageCompleted += AssetPackageImported;
		}

		private static async void AssetPackageImported(string p_name)
		{
			if (!IsInteractPackage(p_name))
				return;

			Debug.Log("[INTERACT] Installation");
			EditorApplication.LockReloadAssemblies();

			try
			{
				await InteractDependencies.InstallDependencies();
				if (IsTutorialEnabled()) await InstallTutorials();

				//Set company name for build
				PlayerSettings.companyName = "Light and Shadows";
				PlayerSettings.productName = "INTERACT";
                				
				//Set 'ScriptChangesWhilePlaying' to 'Stop Playing and Recompile' as default parameter
				//This will only be executed once when loading the project for the first time
				EditorPrefs.SetInt("ScriptCompilationDuringPlay", 2); 
			}
			finally
			{
				EditorApplication.UnlockReloadAssemblies();
			}

			ReimportAssetsFix();
		}

		private static async Task InstallTutorials()
		{
			ListRequest l_list = Client.List(true);
			while (!l_list.IsCompleted)
				await Task.Delay(100);

			if (l_list.Result.All(p_pkg => p_pkg.name != "com.ls.interact.tutorials") &&
					File.Exists("./Assets/INTERACT/00_CORE/Drivers/com.ls.interact.tutorials-1.0.0.tgz"))
			{
				EditorUtility.DisplayProgressBar("INTERACT Tutorials", $"Installing tutorials...", .9f);

				string l_tutorialsPath = $"file:../Assets/INTERACT/00_CORE/Drivers/com.ls.interact.tutorials-1.0.0.tgz";
				AddRequest l_addRequest = Client.Add(l_tutorialsPath);
				while (!l_addRequest.IsCompleted)
					await Task.Delay(100);
				if (l_addRequest.Error != null) Debug.LogError(l_addRequest.Error.message);
				else Debug.Log($"[INTERACT] Package com.ls.interact.tutorials-1.0.0 installed");

				EditorUtility.ClearProgressBar();
			}
		}

		// This is a "monkey patch" to fix an annoying bug where some prefabs lose their references to gameObjects
		// Especially there is an issue with the Import of "FlyArrow" and "NormalizedArrow" prefabs losing their references
		// when importing the compiled unitypackage.
		//
		// When a workaround is found, this function should be removed ASAP.
		//
		// Some reading:
		//   - https://forum.unity.com/threads/importer-prefabimporter-generated-inconsistent-result-for-asset.1004272/
		//   - https://issuetracker.unity3d.com/issues/generated-inconsistent-result-warning-when-reimporting-single-asset
		private static void ReimportAssetsFix()
		{
			AssetDatabase.ImportAsset("Assets", ImportAssetOptions.ImportRecursive | ImportAssetOptions.ForceUpdate);
		}

		private static bool IsInteractPackage(string p_name)
		{
			return p_name.ToLower().StartsWith("interact_");
		}

		// Here we can't use Preferences.EnableTutorials as it is in Interact.Core (so duplication for now)
		private static bool IsTutorialEnabled()
		{
			return EditorPrefs.GetBool("Interact.Tutorials.Enabled", true);
		}
	}
}