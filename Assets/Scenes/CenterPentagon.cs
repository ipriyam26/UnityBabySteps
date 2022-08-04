using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterPentagon : MonoBehaviour
{
    // Start is called before the first frame update
private void OnCollisionEnter2D(Collision2D other) {
    //reverse velocity of the collider
    other.collider.GetComponent<Rigidbody2D>().velocity *= -1;
}
}
