using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    GameObject creature;
    bool timerIsRunning = false;
    float timeRemaining;
    private void Start() {
        creature =   Resources.Load<GameObject>("Creature 1");
        timerIsRunning = true;
        timeRemaining = 10;

    }
    private void Update() {
        if (timerIsRunning) {
            if (timeRemaining > 0) {
                timeRemaining -= Time.deltaTime;
            } else {

                timeRemaining=0;
                timerIsRunning = false;
            }
        }
    }
private void OnCollisionEnter2D(Collision2D other) {
    
if (other.gameObject.tag=="Border"){
    Vector2 strikingVelocity = other.relativeVelocity;
    if(other.gameObject.name=="Horizontal"){
    gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(strikingVelocity.x,-strikingVelocity.y);
    }
    else{
    gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(-strikingVelocity.x,strikingVelocity.y);
    }
}
 

   









}
}
