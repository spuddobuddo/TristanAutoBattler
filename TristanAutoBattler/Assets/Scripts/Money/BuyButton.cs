using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyButton : MonoBehaviour
{
    public int RequiredAmount = 0;
    public Item item;
    public Text buttonText;

    public bool changeState = false;
    public bool changeState2 = false;

    public void OnButtonPress()
    {
        int money = MoneySystem.instance.getMoney();
        if (changeState == false)
        {
            if (money >= RequiredAmount)
            {
                Inventory.instance.addItem(item);
                MoneySystem.instance.removeMoney(RequiredAmount);
                changeState = true;
                buttonText.text = "equip";
            }
        }
        else
        {
            if (changeState2 == false)
            {
                item.Use();
                buttonText.text = "equipped";
                changeState2 = true;
            }
            else
            {
                buttonText.text = "equip";
                changeState2 = false;
            }
        }
    }
}
