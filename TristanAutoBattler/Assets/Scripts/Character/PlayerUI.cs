using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public Text levelText;
    public Text healthText;
    public Text atkText;
    public Text atkSpeedText;
    public Text defenseText;
    public Text critLuckText;
    public Text itemLuckText;
    public Text stageText;

    public int maxhealth;
    public int atk;
    public int level;
    public int atkspeed;
    public int defense;
    public int critluck;
    public int itemluck;
    public int stage;
    public int clicks;
    public int health;

    private void Awake()
    {
        LoadPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        levelText.text = level.ToString();
        healthText.text = health.ToString()+"/"+maxhealth.ToString();
        atkText.text = atk.ToString();
        atkSpeedText.text = atkspeed.ToString();
        defenseText.text = defense.ToString();
        critLuckText.text = critluck.ToString();
        itemLuckText.text = itemluck.ToString();
        stageText.text = stage.ToString();
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        maxhealth = data.maxhealth;
        atk = data.atk;
        level = data.level;
        atkspeed = data.atkspeed;
        defense = data.defense;
        critluck = data.critluck;
        itemluck = data.itemluck;
        clicks = data.clicks;
        health = data.health;
        Debug.Log("loaded");
    }
}
