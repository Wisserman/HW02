using System.Configuration;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;


[CustomPropertyDrawer(typeof(Equipment))]
public class EquipmentDrawer : PropertyDrawer
{
    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return EditorGUIUtility.singleLineHeight * 5 + 8;
    }
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        position.y -= 40;
        EditorGUI.LabelField(position, label);
        position.y += 40;

        EditorGUI.BeginProperty(position, label, property);

        var nameRect = new Rect(position.x, position.y + 20, position.width, 16);
        var rarityRect = new Rect(position.x, position.y + 40, position.width, 16);
        var slotRect = new Rect(position.x, position.y + 60, position.width, 16);
        var valueRect = new Rect(position.x, position.y + 80, position.width, 16);

        EditorGUI.indentLevel++;

        EditorGUI.PropertyField(nameRect, property.FindPropertyRelative("name"));
        EditorGUI.PropertyField(rarityRect, property.FindPropertyRelative("rarity"));
        EditorGUI.PropertyField(slotRect, property.FindPropertyRelative("slot"));
        EditorGUI.PropertyField(valueRect, property.FindPropertyRelative("value"));

        EditorGUI.indentLevel--;

        EditorGUI.EndProperty();
    }
}
