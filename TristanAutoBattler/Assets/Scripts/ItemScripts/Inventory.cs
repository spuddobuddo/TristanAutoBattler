using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    #region Singleton
    public static Inventory instance;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this.gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
    #endregion

    public List<Item> items = new List<Item>();
    Item[] currentItems;

    public delegate void OnItemChanged(Item newItem, Item oldItem);
    public OnItemChanged onItemChanged;

    private void Start()
    {
        int numSlots = System.Enum.GetNames(typeof(EquipmentSlot)).Length;
        currentItems = new Item[numSlots];
    }

    public void Equip (Item newItem)
    {
        int slotIndex = (int)newItem.equipSlot;

        Item oldItem = null;

        if (currentItems[slotIndex] != null)
        {
            oldItem = currentItems[slotIndex];
            addItem(oldItem);
        }

        if (onItemChanged != null)
        {
            onItemChanged.Invoke(newItem, oldItem);
        }

        currentItems[slotIndex] = newItem;
    }

    public void Unequip (int slotIndex)
    {
        if (currentItems[slotIndex] != null)
        {
            Item oldItem = currentItems[slotIndex];
            addItem(oldItem);

            currentItems[slotIndex] = null;

            if (onItemChanged != null)
            {
                onItemChanged.Invoke(null, oldItem);
            }
        }
    }

    public void addItem (Item item)
    {
        items.Add(item);
    }

    public void removeItem (Item item)
    {
        items.Remove(item);
    }
}
