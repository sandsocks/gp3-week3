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

        if (GUILayout.Button("Reset"))
        {
            gameManager.ResetValues();
        }
        if (GUILayout.Button("Feeding Frenzy"))
        {
            gameManager.DamagePowerUp_FeedingFrenzy();
        }
        if (GUILayout.Button("Well Fed"))
        {
            gameManager.DamagePowerUp_WellFed();
        }
    }
}
