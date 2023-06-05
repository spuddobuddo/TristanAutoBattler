using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneySystem : MonoBehaviour
{

    public int money = 0;

    #region Singleton
    public static MoneySystem instance;

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
