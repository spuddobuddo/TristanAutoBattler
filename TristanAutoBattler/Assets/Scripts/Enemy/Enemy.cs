using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int maxH = 10;
    public int curH = 10;
    public int attack;
    public int droppings = 1;
    public Text enemyNameText;
    public Text HPText;
    public Player player;
    public EnemyData enemyData;
    public Image enemyImage;
    

    void Start(){
        SpawnEnemy();
    }
    public void damaged(int x) {
        curH -= x;
    }

    public void addA(int x){
        attack += x;
    }
    
    public void check(){
        isEnemyDead();
        UpdateUI();
    }

    void isEnemyDead() {
        if(curH<=0) {
            EnemyDied();
        }
    }
    private void EnemyDied() {
        SpawnEnemy();

        
    }
    private void SpawnEnemy() {
        droppings = enemyData.droppings;
        curH = enemyData.BaseHitPoints;
        enemyImage.sprite = enemyData.EnemyImage;
        maxH = enemyData.BaseHitPoints;
        enemyNameText.text = enemyData.EnemyName;
        UpdateUI();
         
    }
    private void UpdateUI(){
        HPText.text = curH.ToString()+"/"+maxH.ToString();
    }

    void Update(){
        UpdateUI();
    }

    
}