using UnityEngine;
 using System.Collections;
 
 public class SimpleTimer: MonoBehaviour {
 public float ogtime = 10.0f;
 public float targetTime = 10.0f;
 
 void Update(){
 
 targetTime -= Time.deltaTime;
 
 if (targetTime <= 0.0f)
 {
    timerEnded();
 }
 
 }
 
 void timerEnded()
 {
   targetTime = ogtime;
 }
 
 
 }