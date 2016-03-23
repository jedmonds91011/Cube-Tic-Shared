using UnityEngine;
using System.Collections;
using UnityEditor;

public class MakeUserProfile {

    [MenuItem("Assets/Create/User Profile")]
    public static void Create()
    {
        UserProfile asset = ScriptableObject.CreateInstance<UserProfile>();
        AssetDatabase.CreateAsset(asset, "Assets/DataFile/NewUserProfile.asset");
        AssetDatabase.SaveAssets();
        EditorUtility.FocusProjectWindow();
        Selection.activeObject = asset;
    }

}
