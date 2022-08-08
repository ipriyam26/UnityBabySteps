using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    // Start is called before the first frame update
    Stats stat;
    float health;
    void Start()
    {
        stat = gameObject.GetComponent<Stats>();
        health = stat.health;
    }

    public void hit(float damage)
    {
        health = health - damage;
        if (health <= 0)
        {
            Destroy(gameObject);
            Debug.Log("Destroyed = " + gameObject.name);
        }
    }


    // Update is called once per frame

}
