using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableItems : MonoBehaviour
{
    public ScriptableItem _item;

    private SpriteRenderer _spriteRenderer;

    void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        _spriteRenderer.sprite = _item._itemSprite;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        InventoryManager._instance.Additem(_item);
        Destroy(this.gameObject);
    }
}
