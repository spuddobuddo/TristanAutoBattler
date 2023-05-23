using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public int attackspeed;
    public int attack;
    public Player player;

    public Enemy(int h, int ats, int at){
        health = h;
        attackspeed = ats;
        attack = at;
    }

    public void addA(int x){
        attack += x;
    }
    public void addH(int x){
        health += x;
    }
    public void addAS(int x){
        attackspeed += x;
    }

    public void removeA(int x){
        attack -= x;
    }
    public void removeH(int x){
        health -= x;
    }
    public void removeAS(int x){
        attackspeed -= x;
    }

    public bool isdead() {
        if(health <= 0) {
            return true;
        }
        else{
            return false;
        }
        
    }

    public void hit() {
        player.removeH(attack);
    }
}