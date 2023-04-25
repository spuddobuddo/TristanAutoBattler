using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public int attackspeed;
    public int attack;

    public Enemy(int h, int ats, int at){
        health = h;
        attackspeed = ats;
        attack = at;

    }
}