using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    new public string name = "New Item";
    public Sprite icon = null;

    public EquipmentSlot equipSlot;

    public int healthModifier;
    public int atkModifier;

    public void Use()
    {
        Inventory.instance.Equip(this);
        Debug.Log("Using "+ name);
        RemoveFromInventory();
    }

    public void RemoveFromInventory()
    {
        Inventory.instance.removeItem(this);
    }
}

public enum EquipmentSlot { Head, Face, Weapon }
