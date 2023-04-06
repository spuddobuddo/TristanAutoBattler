using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneySystem : MonoBehaviour
{
    public int money = 0;

    public void addMoney(int x)
    {
        money += x;
    }

    public void removeMoney(int x)
    {
        money -= x;
    }

    public int returnMoney()
    {
        return money;
    }
}
