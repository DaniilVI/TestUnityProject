using UnityEditor;
using System.IO;

public class BuildScript
{
    public static void PerformBuild()
    {
        string[] scenes = {
            "Assets/Scenes/SampleScene.unity",
            "Assets/Scenes/SceneMenu.unity"
             };
        string buildFolder = "build";
        if (!Directory.Exists(buildFolder))
            Directory.CreateDirectory(buildFolder);
        string path = Path.Combine(buildFolder, "FurryUp.exe");

        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions
        {
            scenes = scenes,
            locationPathName = path,
            target = BuildTarget.StandaloneWindows64,
            options = BuildOptions.None
        };

        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }
}