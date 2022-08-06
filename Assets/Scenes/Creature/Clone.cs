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
    private void Start()
    {
        // Starts the timer automatically
        creature = Resources.Load<GameObject>("Creature 1");
        timerIsRunning = true;
        timeRemaining = Random.Range(5, 10);
        stat = creature.GetComponent<Stats>();
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
                Debug.Log("Clonning");
                // Creates a new creature
                GameObject newCreature = Instantiate(creature);
                newCreature.name = gameObject.name + "X";
                Stats newStats = newCreature.GetComponent<Stats>();
                Mutation(newStats, newCreature);

                newCreature.transform.position = gameObject.transform.position;
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }
    }

    private void Mutation(Stats newStat, GameObject newCreature)
    {

        // Mutate the creature
        if ((int)Random.Range(1, 3) == 1)
        {

            int x = (int)Random.Range(0, 200);

            // Mutate color
            if (x % 7 == 0)
            {

                newStat.updateColor(
             new Color(stat.color.r + Random.Range(-odds, odds), stat.color.g + Random.Range(-odds, odds), stat.color.b + Random.Range(-odds, odds))
                );
            }

            // Mutate speed
            else if (x % 5 == 0)
            {

                newStat.updateSpeed(
            stat.speed + Random.Range(-odds, odds));
            }
            // Mutate size
            else if (x % 3 == 0)
            {
                newStat.updateSize(

           stat.size + Random.Range(-odds, odds));
            }

            // Mutate health

            // newStat.health = stat.health + Random.Range(-2f, 2f);

        }

    }
}
