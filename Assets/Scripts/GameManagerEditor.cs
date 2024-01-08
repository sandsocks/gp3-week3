using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(GameManager)), CanEditMultipleObjects]
public class GameManagerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        GameManager gameManager = (GameManager)target;
        if(GUILayout.Button("FeedingFrenzy"))
        {
            gameManager.DamagePowerUp_FeedingFrenzy();
        }
    }
}
