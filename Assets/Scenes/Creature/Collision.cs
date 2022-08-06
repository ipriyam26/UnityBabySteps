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
    


    if (other.gameObject.tag == "Border")
        {
            Border(other);
        }
        else
        {
            if (!timerIsRunning)
            {
                Creature(other);
            }

        }


    }

    private void Border(Collision2D other)
    {
        Vector2 velocity = other.relativeVelocity;
        gameObject.GetComponent<Rigidbody2D>().velocity = velocity;
    }

    private void Creature(Collision2D other)
    {
        Debug.Log("Collided between: " + other.gameObject.name + " and " + gameObject.name);
        if (other.gameObject.name != gameObject.name)
        {
            DestroyOnCollision(other);
        }
        else
        {
            MultiplyOnCollision(other);
        }
    }

    private void DestroyOnCollision(Collision2D other) {
    //Destory the slower gameObject
    if(other.gameObject.GetComponent<Rigidbody2D>().velocity.magnitude > gameObject.GetComponent<Rigidbody2D>().velocity.magnitude)
    {
        Destroy(gameObject);
    }
    else
    {
        Destroy(other.gameObject);
    }
    

}

private void MultiplyOnCollision(Collision2D other) {
    Rigidbody2D otherRigidBody = other.gameObject.GetComponent<Rigidbody2D>();
    Debug.Log("Velocity on collision" + otherRigidBody.velocity);
gameObject.GetComponent<Rigidbody2D>().AddForce(otherRigidBody.velocity *otherRigidBody.velocity,ForceMode2D.Impulse);
GameObject newCreature = Instantiate(creature);
            newCreature.GetComponent<SpriteRenderer>().color = other.gameObject.GetComponent<SpriteRenderer>().color;
            newCreature.transform.position = gameObject.transform.position;
            newCreature.name  =  gameObject.name;
            timeRemaining = 5;
            timerIsRunning = true;
}




}
