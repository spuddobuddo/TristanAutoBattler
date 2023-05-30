using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]

public class EnemyData : ScriptableObject

{
    public string EnemyName;
    public int BaseHitPoints;
    public Sprite EnemyImage;
    public int droppings;
}
