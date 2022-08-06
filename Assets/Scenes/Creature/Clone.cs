using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clone : MonoBehaviour
{
    // Start is called before the first frame update
    float timeRemaining;
    Color color;
    bool timerIsRunning = false;
     GameObject creature;
    // public GameObject creature;
    private void Start()
    {
        // Starts the timer automatically
        creature =  Resources.Load<GameObject>("Creature 1");
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

            }
            else
            {
                // Creates a new creature
            GameObject newCreature = Instantiate(creature);
            newCreature.GetComponent<SpriteRenderer>().color = color;
            Destroy(newCreature.GetComponent<Clone>());
            newCreature.transform.position = gameObject.transform.position;
            newCreature.name  =  gameObject.name;
            // Debug.Log("Created: " + newCreature.name);
            timeRemaining=0;
            timerIsRunning = false;
            }
        }
    }
}
