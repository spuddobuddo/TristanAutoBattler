using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Enemy enemy = new Enemy(10,1,1)
    }

    // Update is called once per frame
    void Update()
    {
        if(enemy.isdead()){
            enemy = new Enemy(10,1,1)
        }
    }
}
