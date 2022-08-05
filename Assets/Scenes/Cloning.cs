using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloning : MonoBehaviour
{
    // Start is called before the first frame update
    float timeRemaining;
    bool timerIsRunning = false;
    public GameObject creature;
    // public GameObject creature;
    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
        
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
            newCreature.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            newCreature.transform.position = gameObject.transform.position;
            newCreature.name  =  gameObject.name + "N";
            Debug.Log("Created: " + newCreature.name);
            timeRemaining=0;
            timerIsRunning = false;
            }
        }
    }
}
