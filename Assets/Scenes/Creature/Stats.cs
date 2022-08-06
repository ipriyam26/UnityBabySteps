using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class Stats : MonoBehaviour
{
    // Start is called before the first frame update
    
     public Color color;
     public float speed;
     public float health;

    // It will cost 0.01f for each unit speed and 0.05f for each unit size.
    // public float costOfMotion=0;

     public float size;

     public void updateColor(Color color)
     {
        Debug.Log("Color" +  gameObject.name);
         this.color = color;
         gameObject.GetComponent<SpriteRenderer>().color = color;
     }
        public void updateSpeed(float speed)
        {
            Debug.Log("Speed: " + gameObject.name);
            this.speed = speed;
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(1, 1) * speed;
        }
        public void updateSize(float size)
        {                Debug.Log("Mutated Size"+gameObject.name);

            this.size = size;
            gameObject.transform.localScale = new Vector2(0.1f, 0.1f) * size;
            gameObject.GetComponent<Rigidbody2D>().mass = size;
        }
        public void updateHealth(float health)
        {
            this.health = health;
        }


     
   
}
