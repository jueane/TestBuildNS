using System;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace Editor
{
    public class TestBuild
    {
        static void GetArgs()
        {
            var argvStrings = Environment.GetCommandLineArgs();
            foreach (var argv in argvStrings)
            {
                Debug.Log($"argv: {argv}");
            }
        }

        public static void PerformBuild()
        {
            GetArgs();

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