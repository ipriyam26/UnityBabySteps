using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloning : MonoBehaviour
{
    // Start is called before the first frame update
    float timeRemaining;
    Color color;
    bool timerIsRunning = false;
    public GameObject creature;
    // public GameObject creature;
    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
        timeRemaining = Random.Range(0, 10);
        color = gameObject.GetComponent<SpriteRenderer>().color;
    }
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                Debug.Log("Time remaining: " + timeRemaining);
            }
            else
            {
                // Creates a new creature
            GameObject newCreature = Instantiate(creature);
            newCreature.GetComponent<SpriteRenderer>().color = color;
            newCreature.transform.position = gameObject.transform.position;
            newCreature.name  =  gameObject.name + "N";
            newCreature.tag = gameObject.tag;
            // Debug.Log("Created: " + newCreature.name);
            timeRemaining=0;
            timerIsRunning = false;
            }
        }
    }
}
