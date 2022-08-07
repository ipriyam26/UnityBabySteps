using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Creator : MonoBehaviour
{
GameObject creature;
    public GameObject creaturePool;
    void Start()
    {
    creature =   Resources.Load<GameObject>("Creature 1");
     CreateCreature(100);  
 
    }

    private void CreateCreature(int v)
    {
        int seed = System.DateTime.Now.Millisecond;
        Debug.Log(seed);
        Random.InitState(seed);
        Color color = new Color(1f,1f,1f);
        float speed = 14;
        float size = 4;
        float health = 100;
        float timeToDeath = 15;
        float timeToReproduce = 10;
        Debug.Log("Color: " + color + " Speed: " + speed + " Size: " + size + " Health: " + health);

        for (int i = 0; i < v; i++)
        {
            GameObject newCreature = Instantiate(creature);
            Stats stats = newCreature.GetComponent<Stats>();
            stats.updateAll(
                color:color,
                speed:speed,
                size:size,
                health:health,
                timeToDeath:timeToDeath,
                timeToReproduce:timeToReproduce
            );
            stats.updateGeneration(1);
            stats.updateGroup(i);
            newCreature.transform.parent = creaturePool.transform;
            newCreature.transform.position = new Vector3(Random.Range(-8,3),Random.Range(1,4),0);
            newCreature.name = "Creature " + i;
        }
    }

}
