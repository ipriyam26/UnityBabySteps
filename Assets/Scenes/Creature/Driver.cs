using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{




    // Start is called before the first frame update
    void Start()
    {
        Vector3 direction = new Vector3(Random.Range(-10,10),Random.Range(-10,10),0);
        // gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        Rigidbody2D rigid =  gameObject.GetComponent<Rigidbody2D>();
        rigid.AddForce(direction * Random.Range(-10,10));

    }




}
