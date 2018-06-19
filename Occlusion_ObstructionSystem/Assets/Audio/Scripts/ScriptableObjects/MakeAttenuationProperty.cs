using UnityEngine;
using System.Collections;
using UnityEditor;

public class MakeAttenuationProperty {
    [MenuItem("Assets/Create/Audio/Attenuation Property")]
    public static void CreateMyAsset()
    {
    AttenuationProperty asset = ScriptableObject.CreateInstance<AttenuationProperty>();

        AssetDatabase.CreateAsset(asset, "Assets/NewAttenuation.asset");
        AssetDatabase.SaveAssets();

        EditorUtility.FocusProjectWindow();

        Selection.activeObject = asset;
    }
}