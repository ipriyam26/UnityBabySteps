using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clone : MonoBehaviour
{





    // Start is called before the first frame update
    float timeRemaining, odds;
    Color color;
    bool timerIsRunning = false;
    GameObject creature;
    // public GameObject creature;
    Stats stat;
    float timeHolder;
    private void Start()
    {
        // Starts the timer automatically
        
        creature = Resources.Load<GameObject>("Creature 1");
        timerIsRunning = true;
        stat = gameObject.GetComponent<Stats>();
        timeRemaining=stat.timeToReproduce;
        timeHolder = timeRemaining;
        odds = 0.1f;
    }
    void Update()
    {
        

        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;

            }
            else
            {
                // Debug.Log("Cloning "+gameObject.name);
                // Creates a new creature
                GameObject newCreature = Instantiate(creature);
                newCreature.name = "Creature " + stat.Group + "X" + (stat.Generation +1);
                newCreature.transform.position = gameObject.transform.position;
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }
    }

    
}
