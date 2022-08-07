using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    GameObject creature;
    bool timerIsRunning = false;
    float timeRemaining;
    Stats stat;
    private void Start()
    {
        creature = Resources.Load<GameObject>("Creature 1");
        timerIsRunning = true;
        timeRemaining = 5;
        stat = gameObject.GetComponent<Stats>();

    }
    private void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
   
Rigidbody2D rigidBody =gameObject.GetComponent<Rigidbody2D>();
Rigidbody2D oRigidBody =other.gameObject.GetComponent<Rigidbody2D>();

        if (other.gameObject.tag == "Border")
        {
            
            Vector2 strikingVelocity = other.relativeVelocity;
            if (other.gameObject.name == "Horizontal")
            {
               rigidBody.velocity = new Vector2(strikingVelocity.x, -strikingVelocity.y);
            }
            else
            {
               rigidBody.velocity = new Vector2(-strikingVelocity.x, strikingVelocity.y);
            }
        }

        else
        {
            if(timerIsRunning || other.gameObject.GetComponent<Collision>().timerIsRunning){
                return;
            }
            Stats oStats = other.gameObject.GetComponent<Stats>();
            if(oStats.Group == gameObject.GetComponent<Stats>().Group && Mathf.Abs(oStats.Generation - stat.Generation) <= 3)
           {
            return;
           }

           if (!oStats.destroyed && !stat.destroyed)
            {

                float myKE = 0.5f *rigidBody.velocity.magnitude *rigidBody.mass *rigidBody.velocity.magnitude;
                float otherKE = 0.5f * oRigidBody.velocity.magnitude * oRigidBody.mass * oRigidBody.velocity.magnitude;


                if (myKE > otherKE)
                {
                    Destroy(other.gameObject);
                    oStats.destroy();
                    rigidBody.velocity = oRigidBody.velocity/2 + rigidBody.velocity;
                    Debug.Log("Destroyed:" + other.gameObject.name);
                }
                else if (myKE < otherKE)
                {
                    Destroy(gameObject);
                    oRigidBody.velocity = rigidBody.velocity/2 + oRigidBody.velocity;
                    gameObject.GetComponent<Stats>().destroy();
                    Debug.Log("Destroyed:" + gameObject.name);
                }
            }
        }
    }
}
