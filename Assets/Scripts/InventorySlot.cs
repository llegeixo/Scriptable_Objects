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

    public void InspectItem()
    {
        if(_slotItem != null)
        {
            _inspectionImage.sprite = _slotItem._itemSprite;
            _inspectionName.text = _slotItem._itemName;
            _inspectionPrice.text = _slotItem._itemPrice.ToString();
            _inspectionDescription.text = _slotItem._itemDescription;

            _inspectionWindow.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
