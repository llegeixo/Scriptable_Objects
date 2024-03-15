using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Items/New Item")]

public class ScriptableItem : ScriptableObject
{
    public enum ItemTypme
    {
        Weapon,
        Armor,
        Shield
    }

    public ItemTypme _itemType;
    public string _itemName;
    public string _itemDescription;
    public int _itemPrice;
    public Sprite _itemSprite;
}
