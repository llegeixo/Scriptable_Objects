using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{

    public ScriptableItem _slotItem;
    public int _slotNumber;

    public GameObject _inspectionWindow;
    public Image _inspectionImage;
    public Text _inspectionName;
    public Text _inspectionPrice;
    public Text _inspectionDescription;

    public Button _deleteButton;

    public Button _closeButton;

    public void InspectItem()
    {
        if(_slotItem != null && _inspectionWindow.activeInHierarchy == false)
        {
            _deleteButton.onClick.AddListener(RemoveItem);
            _closeButton.onClick.AddListener(CloseInspectionWindow);
            
            _inspectionImage.sprite = _slotItem._itemSprite;
            _inspectionName.text = _slotItem._itemName;
            _inspectionPrice.text = _slotItem._itemPrice.ToString();
            _inspectionDescription.text = _slotItem._itemDescription;

            _inspectionWindow.SetActive(true);
        }

        
    }

    
    public void RemoveItem()
    {
       if(InventoryManager._instance._weapons[_slotNumber] != null)
       {
        InventoryManager._instance._weapons[_slotNumber] = null;
        InventoryManager._instance._weaponsNames[_slotNumber].text = "Empty";
        InventoryManager._instance._weaponsSprites[_slotNumber] = null;
       } 

       _slotItem = null;

       
    }

    public void CloseInspectionWindow()
    {
        _deleteButton.onClick.RemoveListener(RemoveItem);
       _inspectionWindow.SetActive(false);
    }
}
