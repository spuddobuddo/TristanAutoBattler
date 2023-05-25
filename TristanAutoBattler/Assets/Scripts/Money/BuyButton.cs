using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyButton : MonoBehaviour
{
    public int RequiredAmount = 0;
    public Item item;

    public void OnButtonPress()
    {
        int money = MoneySystem.instance.getMoney();
        if (money == RequiredAmount)
        {
            Inventory.instance.addItem(item);
            MoneySystem.instance.removeMoney(money);
        }
    }
}
