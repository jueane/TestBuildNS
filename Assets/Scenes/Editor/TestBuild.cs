using System.IO;
using UnityEditor;

namespace Editor
{
    public class TestBuild
    {
        public static void PerformBuild()
        {
            BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
            var location = Path.Combine("build", "bin");
            buildPlayerOptions.locationPathName = location;
            buildPlayerOptions.scenes = new[] { "Assets/Scenes/SampleScene.unity" };
            // BuildPipeline.BuildPlayer(buildPlayerOptions);
            BuildOptions bo = BuildOptions.None | BuildOptions.DetailedBuildReport;

            BuildPipeline.BuildPlayer(new string[] { "Assets/Scenes/SampleScene.unity" }, location, BuildTarget.Switch, bo);
        }
    }
}