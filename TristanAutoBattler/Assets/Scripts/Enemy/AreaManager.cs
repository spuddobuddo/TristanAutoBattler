using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AreaManager : MonoBehaviour
{
    
    public Text stageNumber;
    public List<AreaProfile> areas;
    int enemies = 10;
    int stageN = 0;
    void Start() {
        stageNumber.text = "Stage: " + stageN.ToString()+1;
    }
    public EnemyData GetEnemy(){
        
        if(enemies==0) {
            enemies = 10;
            stageN=stageN+1;
            stageNumber.text = "Stage: " + stageN.ToString()+1;
        }
        
        int x = Random.Range(0,areas[stageN].EnemyProfiles.Count);
        enemies = enemies-1;
        return areas[stageN].EnemyProfiles[x];
    }
}
