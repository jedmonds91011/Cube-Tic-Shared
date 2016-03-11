using UnityEditor;
using UnityEngine;
using System.Collections;

public class EditorScript : MonoBehaviour
{
    [MenuItem("Edit/Reset Playerprefs")]
    public static void DeletePlayerPrefs() { PlayerPrefs.DeleteAll(); }
}