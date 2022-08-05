using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
public Vector3 direction = new Vector3(5,4,0);
// Color color = Color.red;
public float accleration = 50f;
public float friction = 0.3f;
public Quaternion rotation;

public Driver(Vector3 direction, float accleration, Quaternion rotation){
    this.direction = direction;
    this.accleration = accleration;
    this.rotation = rotation;
}

    // Start is called before the first frame update
    void Start()
    {
        // gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        Rigidbody2D rigid =  gameObject.GetComponent<Rigidbody2D>();
        rigid.AddForce(direction * accleration);
    }

    // Update is called once per frame
    void Update()
    {


        

    }

    private void OnCollisionEnter2D(Collision2D other) {
        Vector2 strikingVelocity =  other.relativeVelocity;
        float strikingMass = gameObject.GetComponent<Rigidbody2D>().mass;
        Vector2 strikingForce = strikingVelocity * 1.1f;
        Debug.Log("Striking force: " + strikingForce);
        gameObject.GetComponent<Rigidbody2D>().AddForce(strikingForce,ForceMode2D.Impulse);


    }
}
