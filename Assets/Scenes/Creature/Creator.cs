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
     CreateCreature(3);  
 
    }

    private void CreateCreature(int v)
    {
        int seed = System.DateTime.Now.Millisecond;
        Debug.Log(seed);
        Random.InitState(seed);
        // Color color = new Color(Random.value, Random.value, Random.value);
        Color color = Color.yellow;
        float speed = Random.value * 10;
        float size = Random.Range(4,7);
        float health = Random.value * 10;

        for (int i = 0; i < v; i++)
        {
            GameObject newCreature = Instantiate(creature);
            Stats stats = newCreature.GetComponent<Stats>();
            // stats.color = color;
            // stats.speed = speed;
            // stats.size = size;
            // stats.health = health;
            stats.updateColor(color);
            stats.updateSpeed(speed);
            stats.updateSize(size);
            stats.updateHealth(health);
            newCreature.transform.parent = creaturePool.transform;
            newCreature.transform.position = new Vector3(Random.Range(-8,3),Random.Range(1,4),0);
            newCreature.name = "Creature " + i;
        }
    }

}
