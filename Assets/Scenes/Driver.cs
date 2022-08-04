using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
Vector3 direction = new Vector3(5, 0, 0);


    // Start is called before the first frame update
    void Start()
    {
     
        

    }

    // Update is called once per frame
    void Update()
    {
        //move to the right every third frame


            transform.Translate(direction*Time.deltaTime);
            // rotate every after 10 frames
            if (Time.frameCount % 100 == 0)
            {
            transform.Rotate(0, 0, Random.Range(-90, 90));
            }


        

    }

    // private void OnCollisionEnter2D(Collision2D other) {
    //     transform.rotation = Quaternion.Euler(0, 0, transform.rotation.z*-1);
    // }
}
