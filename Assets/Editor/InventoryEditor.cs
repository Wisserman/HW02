using UnityEngine;
using UnityEditor;
using UnityEditor.UI;



[CustomEditor(typeof(Inventory))]
public class InventoryEditor : Editor
{        
    bool sortIncreasing = true;
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        Inventory inventory = (Inventory)target;

        EditorGUILayout.HelpBox("These buttons sort the Inventory array. Choosing any of the Sort Parameter " +
            "options will initiate the sort, and choosing", MessageType.Info, true);
        GUILayout.Space(16F);
        GUILayout.Label("Sort Parameter");

        GUILayout.BeginHorizontal();
        if (GUILayout.Button("Rarity"))
            inventory.SortRarity(sortIncreasing);
        if (GUILayout.Button("Slot"))
            inventory.SortSlot(sortIncreasing);
        if (GUILayout.Button("Value"))
            inventory.SortValue(sortIncreasing);
        GUILayout.EndHorizontal();

        GUILayout.Space(8);
        GUILayout.Label("Sort Direction");

        GUILayout.BeginHorizontal();
        if (GUILayout.Button("Increasing"))
            sortIncreasing = true;
        if (GUILayout.Button("Decreasing"))
            sortIncreasing = false;
        GUILayout.EndHorizontal();
    }
}
