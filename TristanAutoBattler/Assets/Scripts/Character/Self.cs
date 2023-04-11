using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Self : MonoBehaviour
{
    public int maxhealth = 10;
    public int atk = 0;
    public int level = 1;
    public int atkspeed = 0;
    public int defense = 0;
    public int critluck = 0; //crits
    public int itemluck = 0; //(pootis)
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    public void addL(int p){
        level += p;
    }
    public void addH(int p){
        maxhealth += p;
    }
    public void addA(int p){
        atk += p;
    }
    public void addAS(int p){
        atkspeed += p;
    }
    public void addD(int p){
        defense += p;
    }
    public void addCL(int p){
        critluck += p;
    }
    public void addIL(int p){
        itemluck += p;
    }

    public void removeL(int p){
        level -= p;
    }
    public void removeH(int p){
        maxhealth -= p;
    }
    public void removeA(int p){
        atk -= p;
    }
    public void removeAS(int p){
        atkspeed -= p;
    }
    public void removeD(int p){
        defense -= p;
    }
    public void removeCL(int p){
        critluck -= p;
    }
    public void removeIL(int p){
        itemluck -= p;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
