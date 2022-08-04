using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureCloner : MonoBehaviour
{
    public GameObject creature;
    public GameObject creaturePool;
    void Start()
    {
     CreateCreature(50);   
    }

    private void CreateCreature(int v)
    {
        for (int i = 0; i < v; i++)
        {
            GameObject newCreature = Instantiate(creature);
            newCreature.transform.position = new Vector3(Random.Range(-8,3),Random.Range(1,4),0);
            newCreature.transform.rotation = Quaternion.Euler(0, 0, Random.Range(-180, 180));
            newCreature.transform.parent = creaturePool.transform;
            
            newCreature.name = "Creature " + i;
        }
    }

}
