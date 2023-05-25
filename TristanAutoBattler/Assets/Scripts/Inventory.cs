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

    public void addItem (Item item)
    {
        items.Add(item);
    }

    public void removeItem (Item item)
    {
        items.Remove(item);
    }
}
