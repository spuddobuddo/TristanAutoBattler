using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxh = 10;
    public int curH = 10;
    public int attack;
    public Player player;
    public EnemyData enemyData;
    public Image enemyImage;
    
    public void damaged(int x) {
        curH -= x;
    }

    public void addA(int x){
        attack += x;
    }

    

    public void hit() {
        player.removeH(attack);
    }
}