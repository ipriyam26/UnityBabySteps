using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clone : MonoBehaviour
{





    // Start is called before the first frame update
    float timeRemaining;
    Color color;
    bool timerIsRunning = false;

    // public GameObject creature;
    Stats stat;

    private void Start()
    {
        // Starts the timer automatically
        
        timerIsRunning = true;
        stat = gameObject.GetComponent<Stats>();
        Debug.Log("Time to reproduce: "+stat.timeToReproduce);
        timeRemaining=stat.timeToReproduce;


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
                // Creates a new creature
                GameObject newCreature = Instantiate(gameObject);
                Stats nStat = newCreature.GetComponent<Stats>();
                newCreature.name = "Creature " + nStat.Group + "X" + (nStat.Generation +1);
                Debug.Log("Created: " + newCreature.name);
                nStat.updateGeneration(stat.Generation + 1);
                nStat.updateGroup(stat.Group);
                newCreature.transform.parent = gameObject.transform.parent;
                newCreature.transform.position = gameObject.transform.position;
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }
    }

    
}
