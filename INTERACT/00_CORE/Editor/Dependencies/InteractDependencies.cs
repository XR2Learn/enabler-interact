using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEditor;
using UnityEditor.PackageManager;
using UnityEditor.PackageManager.Requests;
using UnityEngine;

namespace InteractEditor.Dependencies
{
  public interface IPackage
  {
    string Identifier { get; }
    string Version { get; }
    string PackageName { get; }
    Task<Error> Install();
  }

  public abstract class APackage : IPackage
  {
    public string Identifier { get; protected set; }
    public string Version { get; protected set; }
    public string PackageName => $"{Identifier}@{Version}";
    public abstract Task<Error> Install();
  }

  public abstract class APackageWithLocal : APackage
  {
    protected string GetPackagePath()
    {
      string l_depsDir = "file:../Assets/INTERACT/00_CORE/Editor/Dependencies";
      return $"{l_depsDir}/{Identifier}-{Version}.tgz";
    }
  }

  public class PackageWithLocalFallback : APackageWithLocal
  {
    public PackageWithLocalFallback(string p_identifier, string p_version)
    {
      Identifier = p_identifier;
      Version = p_version;
    }

    public override async Task<Error> Install()
    {
      Debug.Log($"Install package {PackageName}");
      AddRequest l_req = Client.Add(PackageName);
      while (!l_req.IsCompleted)
        await Task.Delay(100);

      if (l_req.Status == StatusCode.Failure)
      {
        Debug.LogWarning($"Failed to install package from registry: {l_req.Status}");
        Debug.LogWarning($"{l_req.Error.message}");

        if (l_req.Error.errorCode == ErrorCode.NotFound)
        {
          Debug.Log($"Installing package {PackageName} locally");
          string l_pkgPath = GetPackagePath();
          Debug.Log($"Package path is {l_pkgPath}");
          l_req = Client.Add(l_pkgPath);
          while (!l_req.IsCompleted)
            await Task.Delay(100);

          return l_req.Error;
        }
      }

      return l_req.Error;
    }
  }

  public class PackageFromRegistry : APackage
  {
    public PackageFromRegistry(string p_identifier, string p_version)
    {
      Identifier = p_identifier;
      Version = p_version;
    }

    public override async Task<Error> Install()
    {
      AddRequest l_req = Client.Add(PackageName);
      while (!l_req.IsCompleted)
        await Task.Delay(100);
      return l_req.Error;
    }
  }

  public class PackageLocalOnly : APackageWithLocal
  {
    public PackageLocalOnly(string p_identifier, string p_version)
    {
      Identifier = p_identifier;
      Version = p_version;
    }

    public override async Task<Error> Install()
    {
      string l_pkgPath = GetPackagePath();
      AddRequest l_req = Client.Add(l_pkgPath);
      while (!l_req.IsCompleted)
        await Task.Delay(100);

      return l_req.Error;
    }
  }

  public static class InteractDependencies
  {
    [Serializable]
    public class Dependencies
    {
      [Serializable]
      public class Entry
      {
        public string identifier;
        public string version;
        public string kind;
      }

      public List<Entry> entries;

      public static Dependencies CreateFromJson(string p_jsonString)
      {
        return JsonUtility.FromJson<Dependencies>(p_jsonString);
      }
    }

    private static string ConfigFile = "Assets/INTERACT/00_CORE/Editor/Dependencies/dependencies.json";

    public static async Task InstallDependencies()
    {
      IEnumerable<IPackage> l_dependencies = GetDependencies();

      foreach (IPackage l_dep in l_dependencies)
      {
        UnityEditor.EditorUtility.DisplayProgressBar("INTERACT Dependency", $"Installing {l_dep.Identifier}...", .9f);

        Error l_err = await l_dep.Install();

        if (l_err == null)
        {
          Debug.Log($"[INTERACT] Package \"{l_dep.Identifier}\" installed");
        }
        else
        {
          Debug.LogError($"[INTERACT] Failed to install package (\"{l_dep.Identifier}\") ({l_err.errorCode})");
          Debug.LogError($"{l_err.message}");
        }

        UnityEditor.EditorUtility.ClearProgressBar();
      }
    }

    public static async Task<bool> AreDependenciesInstalled()
    {
      IEnumerable<IPackage> l_dependencies = GetDependencies();
      ListRequest l_list = Client.List(true, true);
      while (!l_list.IsCompleted)
        await Task.Delay(100);
      
      List<string> l_installedPackages = l_list.Result.Select(p_pkg => p_pkg.name).ToList();
      return l_dependencies.All(p_dep => l_installedPackages.Contains(p_dep.Identifier));
    }

    private static IEnumerable<IPackage> GetDependencies()
    {
      TextAsset l_dependenciesJson = AssetDatabase.LoadAssetAtPath<TextAsset>(ConfigFile);
      Dependencies l_entries = Dependencies.CreateFromJson(l_dependenciesJson.text);

      IEnumerable<IPackage> l_dependencies = l_entries.entries.Select(p_entry =>
      {
        IPackage l_result = p_entry.kind switch
        {
          "FROM_REGISTRY_WITH_LOCAL_FALLBACK" => new PackageWithLocalFallback(p_entry.identifier, p_entry.version),
          "FROM_REGISTRY" => new PackageFromRegistry(p_entry.identifier, p_entry.version),
          "LOCAL_ONLY" => new PackageLocalOnly(p_entry.identifier, p_entry.version),
          _ => null
        };

        if (l_result == null)
        {
          Debug.LogError($"Package type unknown: {p_entry.kind}");
        }

        return l_result;
      });

      return l_dependencies;
    }
  }
}