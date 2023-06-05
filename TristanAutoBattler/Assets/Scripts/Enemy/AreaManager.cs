using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class AreaManager : MonoBehaviour
{
    public AreaProfile areaProfile;
    public EnemyData GetEnemy(){
        int x = Random.Range(0,areaProfile.EnemyProfiles.Count);
        return areaProfile.EnemyProfiles[x];
    }
}
