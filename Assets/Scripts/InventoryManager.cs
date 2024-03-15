using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager _instance;

    public ScriptableItem[] _weapons;
    public Text[] _weaponsNames;
    public Image[] _weaponsSprites;
    public InventorySlot[] _weaponSlots;

    void Awake()
    {
        _instance = this;
    }

    public void Additem(ScriptableItem item)
    {
        for (int i = 0; i < _weapons.Length; i++)
        {
            if(_weapons[i] == null)
            {
                _weapons[i] = item;
                _weaponsNames[i].text = item._itemName;
                _weaponsSprites[i].sprite = item._itemSprite;

                _weaponSlots[i]._slotItem = item;
                _weaponSlots[i]._slotNumber = i;


                return;
            }
        }
    }
}
