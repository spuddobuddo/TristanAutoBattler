using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneySystem : MonoBehaviour
{
    public static MoneySystem instance;

    int money = 0;

    private void Awake()
    {
        instance = this;
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
