using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public Text stat1;
    public Text stat2;
    public Text stat3;
    public Text stat4;
    public Text stat5;
    public Text stat6;
    public Text stat7;

    public Player player;
    
    // Update is called once per frame
    void Update()
    {
        stat1.text = player.getHealth().ToString()+"/"+player.getMaxHealth().ToString();
        stat2.text = player.getAtk().ToString();
        stat3.text = player.getLevel().ToString();
        stat4.text = player.getAtkspeed().ToString();
        stat5.text = player.getDefense().ToString();
        stat6.text = player.getCritluck().ToString();
        stat7.text = player.getItemluck().ToString();
    }


    
    
    void DisplayStat4(int stat)
    {
        stat4.text = stat.ToString();
    }
    void DisplayStat5(int stat)
    {
        stat5.text = stat.ToString();
    }
    void DisplayStat6(int stat)
    {
        stat6.text = stat.ToString();
    }
    void DisplayStat7(int stat)
    {
        stat7.text = stat.ToString();
    }
}
