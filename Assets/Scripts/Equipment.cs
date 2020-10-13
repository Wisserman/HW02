using System;
using UnityEngine;

public enum Rarity { Common, Uncommon, Rare, Legendary }
public enum Slot { LeftHand, RightHand, Head, Feet }

[Serializable]
public class Equipment
{
    public string name;
    public Rarity rarity;
    public Slot slot;
    public int value;
}
