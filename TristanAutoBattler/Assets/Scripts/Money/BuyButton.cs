using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyButton : MonoBehaviour
{
    public int RequiredAmount = 0;
    public Item item;
    public Text buttonText;

    bool changeState = false;

    public void OnButtonPress()
    {
        int money = MoneySystem.instance.getMoney();
        if (changeState == false)
        {
            if (money == RequiredAmount)
            {
                Inventory.instance.addItem(item);
                MoneySystem.instance.removeMoney(money);
                changeState = true;
                buttonText.text = "equip";
            }
        }
        else
        {

        }
    }
}
