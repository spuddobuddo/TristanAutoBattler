using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxhealth = 10;
    public int atk = 0;
    public int level = 1;
    public int atkspeed = 0;
    public int defense = 0;
    public int critluck = 0; //crits
    public int itemluck = 0; //(pootis)

    public void addL(int p)
    {
        level += p;
        Debug.Log("added " + p + " level(s)");
    }
    public void addH(int p)
    {
        maxhealth += p;
        Debug.Log("added " + p + " health");
    }
    public void addA(int p)
    {
        atk += p;
        Debug.Log("added " + p + " attack");
    }
    public void addAS(int p)
    {
        atkspeed += p;
        Debug.Log("added " + p + " attackspeed");
    }
    public void addD(int p)
    {
        defense += p;
        Debug.Log("added " + p + " defense");
    }
    public void addCL(int p)
    {
        critluck += p;
        Debug.Log("added " + p + " critluck");
    }
    public void addIL(int p)
    {
        itemluck += p;
        Debug.Log("added " + p + " itemluck");
    }

    public void removeL(int p)
    {
        level -= p;
        Debug.Log("removed " + p + " level(s)");
    }
    public void removeH(int p)
    {
        maxhealth -= p;
        Debug.Log("removed " + p + " health");
    }
    public void removeA(int p)
    {
        atk -= p;
        Debug.Log("removed " + p + " attack");
    }
    public void removeAS(int p)
    {
        atkspeed -= p;
        Debug.Log("removed " + p + " attackspeed");
    }
    public void removeD(int p)
    {
        defense -= p;
        Debug.Log("removed " + p + " defense");
    }
    public void removeCL(int p)
    {
        critluck -= p;
        Debug.Log("removed " + p + " critluck");
    }
    public void removeIL(int p)
    {
        itemluck -= p;
        Debug.Log("removed " + p + " itemluck");
    }

    public int getHealth()
    {
        return maxhealth;
    }

    public int getAtk()
    {
        return atk;
    }

    public int getLevel()
    {
        return level;
    }

    public int getAtkspeed()
    {
        return atkspeed;
    }

    public int getDefense()
    {
        return defense;
    }

    public int getCritluck()
    {
        return critluck;
    }

    public int getItemluck()
    {
        return itemluck;
    }
}
