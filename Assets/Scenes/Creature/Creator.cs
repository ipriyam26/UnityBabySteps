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
     CreateCreature(10);  
 
    }

    private void CreateCreature(int v)
    {
        for (int i = 0; i < v; i++)
        {
            GameObject newCreature = Instantiate(creature);
            Stats stats = newCreature.GetComponent<Stats>();
            stats.color = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
            stats.speed = Random.Range(5, 10);
            stats.health = Random.Range(10, 30);
            stats.size = Random.Range(5, 10);
            

            newCreature.transform.position = new Vector3(Random.Range(-8,3),Random.Range(1,4),0);
            newCreature.transform.parent = creaturePool.transform;
            newCreature.name = "Creature " + i;
        }
    }

}
