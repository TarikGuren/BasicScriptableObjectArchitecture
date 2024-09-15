using UnityEditor;
using UnityEngine;

namespace BasicScriptableObjectArchitecture.Variables.Editor
{
    // [CustomEditor(typeof(GameVariable<>), true)]
    // public class GameVariableEditor : UnityEditor.Editor
    // {
    //     private GameVariable Target { get { return (GameVariable)target; } }
    //
    //     public override void OnInspectorGUI()
    //     {
    //         serializedObject.Update();
    //         
    //         var valueProperty = serializedObject.FindProperty("Value");
    //         EditorGUILayout.PropertyField(valueProperty, GUIContent.none);
    //     }
    // }
}