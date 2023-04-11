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
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    public void addL(int p){
        PlayerData.level += p;
        Debug.Log("added "+p+" level(s)");
    }
    public void addH(int p){
        PlayerData.maxhealth += p;
        Debug.Log("added "+p+" health");
    }
    public void addA(int p){
        PlayerData.atk += p;
        Debug.Log("added "+p+" attack");
    }
    public void addAS(int p){
        PlayerData.atkspeed += p;
        Debug.Log("added "+p+" attackspeed");
    }
    public void addD(int p){
        PlayerData.defense += p;
        Debug.Log("added "+p+" defense");
    }
    public void addCL(int p){
        PlayerData.critluck += p;
        Debug.Log("added "+p+" critluck");
    }
    public void addIL(int p){
        PlayerData.itemluck += p;
        Debug.Log("added "+p+" itemluck");
    }

    public void removeL(int p){
        PlayerData.level -= p;
        Debug.Log("removed "+p+" level(s)");
    }
    public void removeH(int p){
        PlayerData.maxhealth -= p;
        Debug.Log("removed "+p+" health");
    }
    public void removeA(int p){
        PlayerData.atk -= p;
        Debug.Log("removed "+p+" attack");
    }
    public void removeAS(int p){
        PlayerData.atkspeed -= p;
        Debug.Log("removed "+p+" attackspeed");
    }
    public void removeD(int p){
        PlayerData.defense -= p;
        Debug.Log("removed "+p+" defense");
    }
    public void removeCL(int p){
        PlayerData.critluck -= p;
        Debug.Log("removed "+p+" critluck");
    }
    public void removeIL(int p){
        PlayerData.itemluck -= p;
        Debug.Log("removed "+p+" itemluck");
    }
    // Update is called once per frame
    void Update()
    {
        DisplayStat1(PlayerData.maxhealth);
        DisplayStat2(PlayerData.atk);
        DisplayStat3(PlayerData.level);
        DisplayStat4(PlayerData.atkspeed);
        DisplayStat5(PlayerData.defense);
        DisplayStat6(PlayerData.critluck);
        DisplayStat7(PlayerData.itemluck);


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
