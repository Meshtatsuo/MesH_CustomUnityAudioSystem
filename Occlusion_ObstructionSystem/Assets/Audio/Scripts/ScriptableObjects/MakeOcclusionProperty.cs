using UnityEngine;
using System.Collections;
using UnityEditor;

public class MakeOcclusionProperty {
    [MenuItem("Assets/Create/Audio/Occlusion Property")]
    public static void CreateMyAsset()
    {
    OcclusionProperty asset = ScriptableObject.CreateInstance<OcclusionProperty>();

        AssetDatabase.CreateAsset(asset, "Assets/NewOcclusion.asset");
        AssetDatabase.SaveAssets();

        EditorUtility.FocusProjectWindow();

        Selection.activeObject = asset;
    }
}