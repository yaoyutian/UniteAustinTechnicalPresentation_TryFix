using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(boolean))]
public class booleanPropertyDrawercs : PropertyDrawer
{

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        var booleanProp = property.FindPropertyRelative("boolValue");
        booleanProp.boolValue = EditorGUI.Toggle(position, label, booleanProp.boolValue);
    }
}
