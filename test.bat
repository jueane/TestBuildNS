@REM D:\UnityEditors\2020.3.36f1\Editor\Unity.exe -projectPath C:\Jenkins\workspace\publish_inner_win64 -quit -batchmode -nographics -returnlicense -username ******** -password ******** -logFile C:\Jenkins\workspace\publish_inner_win64/unity3d_editor.log

set WORKSPACE=%CD%
@REM "C:\Program Files\Unity\2020.3.19f1\Editor\Unity.exe"  -quit -batchmode -nographics -serial  -buildTarget Switch -projectPath "C:\TestBuildNS" -executeMethod TestBuild2.PerformBuild
dir

@REM "C:\Program Files\Unity\2020.3.19f1\Editor\Unity.exe" -quit -batchmode -nographics -buildTarget Win64 -projectPath "./" -executeMethod Editor.TestBuild.PerformBuild

@REM C:\2020.3.38f1\Editor\Unity.exe -quit -batchmode -nographics -projectPath C:\TestBuildNS -executeMethod Editor.TestBuild.PerformBuild  -stackTraceLogType Full  -logFile d:\1.txt

"C:\Program Files\Unity\2020.3.19f1\Editor\Unity.exe" -quit -batchmode -nographics -projectPath C:\TestBuildNS -executeMethod Editor.TestBuild.PerformBuild  -stackTraceLogType Full  -logFile d:\1.txt

-quit -batchmode -nographics -serial "${unity_publish_key}" -username "${unity_publish_user_name}" -password "${unity_publish_user_password}" -logFile "${WORKSPACE}/unity3d_editor.log" -buildTarget Switch -projectPath "D:\Publish\Switch\Project" -executeMethod CommandLineTools.BuildSwitchWithArgs