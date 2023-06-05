using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyUI : MonoBehaviour
{
    public Text moneyText;
    // Start is called before the first frame update
    void Start()
    {
        moneyText.text = "Money: " + MoneySystem.instance.getMoney().ToString();
    }

    // Update is called once per frame
    void Update()
    {
        moneyText.text = "Money: " + MoneySystem.instance.getMoney().ToString();
    }
}
