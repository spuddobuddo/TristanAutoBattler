using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneySystem : MonoBehaviour
{
    private int money = 0;

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
