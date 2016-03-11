﻿using UnityEngine;
using System.Collections;

public class ShowStatusWhenConnecting : MonoBehaviour
{
    public GUISkin Skin;

    void OnGUI()
    {
        if (Skin != null)
        {
            GUI.skin = Skin;
        }

        float width = Screen.width / 2.0f;
        float height = Screen.height / 3.0f;

        Rect centeredRect = new Rect((Screen.width - width) / 2, (Screen.height - height) / 2, width, height);

        GUILayout.BeginArea(centeredRect, GUI.skin.box);
        {
            GUILayout.Label("Connecting" + GetConnectingDots(), GUI.skin.customStyles[0]);
            GUILayout.Label("Status: " + PhotonNetwork.connectionStateDetailed);
        }
        GUILayout.EndArea();

        if (PhotonNetwork.connectionStateDetailed == PeerState.Joined)
        {
            enabled = false;
        }
    }

    string GetConnectingDots()
    {
        string str = "";
        int numberOfDots = Mathf.FloorToInt(Time.timeSinceLevelLoad * 3f % 4);

        for (int i = 0; i < numberOfDots; ++i)
        {
            str += " .";
        }

        return str;
    }
}