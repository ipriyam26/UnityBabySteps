using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallColission : MonoBehaviour
{
    // Start is called before the first frame update
  private void OnCollisionEnter2D(Collision2D other) {

    Vector2 strikingVelocity =  other.relativeVelocity;
    float strikingMass = other.collider.GetComponent<Rigidbody2D>().mass;
    Vector2 strikingForce = strikingVelocity * 1;
    Debug.Log("Striking force on wall: " + strikingForce*-1);
    other.collider.GetComponent<Rigidbody2D>().AddForce(strikingForce*-1, ForceMode2D.Impulse);

//    if(other.collider.GetComponent<SpriteRenderer>().color == Color.red){
//        other.collider.GetComponent<SpriteRenderer>().color = Color.blue;
//    }
// else{
    other.collider.GetComponent<SpriteRenderer>().color = Color.red;
// }
    

  } 
}
