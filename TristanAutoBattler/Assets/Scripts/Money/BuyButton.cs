using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyButton : MonoBehaviour
{
    public int RequiredAmount = 0;

    public void OnButtonPress()
    {
        int money = MoneySystem.instance.getMoney();
        if (money == RequiredAmount)
        {
            Debug.Log("bought");
        }
    }
}
