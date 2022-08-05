using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureCloner : MonoBehaviour
{
    public GameObject creature;
    public GameObject creaturePool;
    void Start()
    {
     CreateCreature(2);   
    }

    private void CreateCreature(int v)
    {
        for (int i = 0; i < v; i++)
        {
            Random.InitState(((int)System.DateTime.Now.Ticks));
            GameObject newCreature = Instantiate(creature);
            newCreature.GetComponent<SpriteRenderer>().color = new Color(0.5f, 0.5f, 0.5f);
            newCreature.transform.position = new Vector3(Random.Range(-8,3),Random.Range(1,4),0);
            newCreature.transform.parent = creaturePool.transform;

            newCreature.name = "Creature " + i;
        }
    }

}
