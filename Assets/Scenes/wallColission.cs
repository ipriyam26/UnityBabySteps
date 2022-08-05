using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallColission : MonoBehaviour
{
    // Start is called before the first frame update
  private void OnCollisionEnter2D(Collision2D other) {
    // // Vector2 direction = new Vector2(Random.Range(-5,8), Random.Range(-5,10));
    // // other.collider.GetComponent<Rigidbody2D>().AddForce( direction, ForceMode2D.Impulse);

    // Vector2 strikingVelocity =  other.relativeVelocity;
    // float strikingMass = other.collider.GetComponent<Rigidbody2D>().mass;
    // Vector2 strikingForce = strikingVelocity * strikingMass;
    // Debug.Log("Striking force on wall: " + strikingForce*-1);
    // other.collider.GetComponent<Rigidbody2D>().AddForce(strikingForce*-1, ForceMode2D.Impulse);

  } 
}
