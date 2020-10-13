using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Custom serializable class
[Serializable]
public class Inventory : MonoBehaviour
{
    public Equipment[] currentlyEquipped;
    
    public void SortRarity(bool sortIncreasing)
    {
        int n = currentlyEquipped.Length;
        for (int i = 1; i < n; ++i)
        {
            Equipment key = currentlyEquipped[i];
            int j = i - 1;

            // Move elements of currentlyEquipped[0..i-1], 
            // that are greater than key, 
            // to one position ahead of 
            // their current position 
            if (sortIncreasing)
            {
                while (j >= 0 && currentlyEquipped[j].rarity > key.rarity)
                {
                    currentlyEquipped[j + 1] = currentlyEquipped[j];
                    j = j - 1;
                }
            }
            else
            {
                while (j >= 0 && currentlyEquipped[j].rarity < key.rarity)
                {
                    currentlyEquipped[j + 1] = currentlyEquipped[j];
                    j = j - 1;
                }
            }
            currentlyEquipped[j + 1] = key;
        }
    }

    public void SortSlot(bool sortIncreasing)
    {
        int n = currentlyEquipped.Length;
        for (int i = 1; i < n; ++i)
        {
            Equipment key = currentlyEquipped[i];
            int j = i - 1;

            // Move elements of currentlyEquipped[0..i-1], 
            // that are greater than key, 
            // to one position ahead of 
            // their current position 
            if (sortIncreasing)
            {
                while (j >= 0 && currentlyEquipped[j].slot > key.slot)
                {
                    currentlyEquipped[j + 1] = currentlyEquipped[j];
                    j = j - 1;
                }
            }
            else
            {
                while (j >= 0 && currentlyEquipped[j].slot < key.slot)
                {
                    currentlyEquipped[j + 1] = currentlyEquipped[j];
                    j = j - 1;
                }
            }
            currentlyEquipped[j + 1] = key;
        }
    }

    public void SortValue(bool sortIncreasing)
    {
        int n = currentlyEquipped.Length;
        for (int i = 1; i < n; ++i)
        {
            Equipment key = currentlyEquipped[i];
            int j = i - 1;

            // Move elements of currentlyEquipped[0..i-1], 
            // that are greater than key, 
            // to one position ahead of 
            // their current position 
            if (sortIncreasing)
            {
                while (j >= 0 && currentlyEquipped[j].value > key.value)
                {
                    currentlyEquipped[j + 1] = currentlyEquipped[j];
                    j = j - 1;
                }
            }
            else
            {
                while (j >= 0 && currentlyEquipped[j].value < key.value)
                {
                    currentlyEquipped[j + 1] = currentlyEquipped[j];
                    j = j - 1;
                }
            }
            currentlyEquipped[j + 1] = key;
        }
    }
}
