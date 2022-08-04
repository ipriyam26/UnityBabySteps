using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallColission : MonoBehaviour
{
    // Start is called before the first frame update
  private void OnCollisionEnter2D(Collision2D other) {
    other.collider.transform.rotation = Quaternion.Euler(0, 0, -180);
    // send back the collider with force
    other.collider.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-5,5), Random.Range(-5,5)), ForceMode2D.Impulse);
    // other.collider.transform.Translate(new Vector3(-3,1,0));
  } 
}
