using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int maxhealth;
    public int atk;
    public int level;
    public int atkspeed;
    public int defense;
    public int critluck;
    public int itemluck;

    public PlayerData (Player player)
    {
        maxhealth = player.maxhealth;
        atk = player.atk;
        level = player.level;
        atkspeed = player.atkspeed;
        defense = player.defense;
        critluck = player.critluck;
        itemluck = player.itemluck;
    }
}
