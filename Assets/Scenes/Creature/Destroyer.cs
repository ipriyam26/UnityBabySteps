using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    float timeRemaining;
    bool timerIsRunning = false;
    private void Start()
    {
        // timeRemaining = Random.Range(9, 30);
        timeRemaining = 15; 
        timerIsRunning = true;
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
                // Debug.Log("Destroyed:"+gameObject.name);
                timeRemaining = 0;
                timerIsRunning = false;
                Destroy(gameObject);
            }
        }
    }
}
