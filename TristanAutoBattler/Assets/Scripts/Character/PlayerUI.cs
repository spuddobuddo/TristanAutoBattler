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
        DisplayStat1(player.getHealth());
        DisplayStat2(player.getAtk());
        DisplayStat3(player.getLevel());
        DisplayStat4(player.getAtkspeed());
        DisplayStat5(player.getDefense());
        DisplayStat6(player.getCritluck());
        DisplayStat7(player.getItemluck());
    }

    void DisplayStat1(int stat)
    {
        stat1.text = stat.ToString();
    }
    void DisplayStat2(int stat)
    {
        stat2.text = stat.ToString();
    }
    void DisplayStat3(int stat)
    {
        stat3.text = stat.ToString();
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
