using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    new public string name = "New Item";
    public Sprite icon = null;

    public EquipmentSlot equipSlot;

    public int maxHealthMod;
    public int atkMod;
    public int atkSpeedMod;
    public int defenseMod;
    public int critLuckMod;
    public int itemLuckMod;

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

    public int getmaxHealthMod()
    {
        return maxHealthMod;
    }

    public int getAtkMod()
    {
        return atkMod;
    }

    public int getAtkSpeedMod()
    {
        return atkSpeedMod;
    }

    public int getDefenseMod()
    {
        return defenseMod;
    }

    public int getCritLuckMod()
    {
        return critLuckMod;
    }

    public int getItemLuckMod()
    {
        return itemLuckMod;
    }
}

public enum EquipmentSlot { Head, Face, Weapon }
