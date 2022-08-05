using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureCloner : MonoBehaviour
{
GameObject creature;
    public GameObject creaturePool;
    void Start()
    {
    creature =   Resources.Load<GameObject>("Creature 1");
    Debug.Log("Creature: " + creature.name);
     CreateCreature(10);  
 
    }

    private void CreateCreature(int v)
    {
        for (int i = 0; i < v; i++)
        {
            // Random.InitState(((int)System.DateTime.Now.Ticks));
            GameObject newCreature = Instantiate(creature);
            newCreature.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            newCreature.transform.position = new Vector3(Random.Range(-8,3),Random.Range(1,4),0);
            newCreature.transform.parent = creaturePool.transform;
            newCreature.tag = "Creature"+i;
            newCreature.name = "Creature " + i;
        }
    }

}
