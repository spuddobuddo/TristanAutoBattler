using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneySystem : MonoBehaviour
{
    public static MoneySystem instance;

    public int money = 0;

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
    public void addMoney(int x)
    {
        money += x;
    }

    public void removeMoney(int x)
    {
        money -= x;
    }

    public int getMoney()
    {
        return money;
    }
}
