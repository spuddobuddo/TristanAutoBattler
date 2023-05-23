using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gealth : MonoBehaviour
{
    public Text healthText;
    public Player player;

    // Update is called once per frame
    void Update()
    {
        healthText.text = player.getHealth().ToString()+"/"+player.getMaxHealth().ToString();
    }
}
