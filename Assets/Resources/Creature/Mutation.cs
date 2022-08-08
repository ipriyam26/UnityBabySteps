using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mutation : MonoBehaviour
{
    // Start is called before the first frame update

    public class StatHolder
    {
        public Color color;
        public float speed;
        public float health;
        public float size;
        public float timeToDeath;
        public float timeToReproduce;

        public StatHolder(Stats stat)
        {
            this.color = stat.color;
            this.speed = stat.speed;
            this.health = stat.health;
            this.size = stat.size;
            this.timeToReproduce = stat.timeToReproduce;
        }

    }
    private void Awake()
    {
        Stats stat = gameObject.GetComponent<Stats>();
        Mutations(stat, gameObject);
    }







    private StatHolder speedMutation(StatHolder stat)
    {

        int odd = (int)Random.Range(0, 10);
        float oldSpeed = stat.speed;
        if (odd % 3 == 0)
        {
            stat.speed = stat.speed + Random.Range(-0.1f,0.1f);

            float diff = oldSpeed - stat.size;
            float r=stat.color.r ;
            if(stat.color.r+diff<=1f && stat.color.r+diff>=0f)
            {
                r = stat.color.r + diff;
            }
            
            stat.color = new Color(r, stat.color.g + diff, stat.color.b + diff);
        }
        return stat;

    }
    private StatHolder healthMutation(StatHolder stat)
    {
        int odd = (int)Random.Range(0, 10);
        float oldHealth = stat.health;
        if (odd % 3 == 0)
        {
            stat.health = stat.health + Random.Range(-1f, 1f);
            float diff = oldHealth - stat.health;
            float g = stat.color.g + diff;
            stat.color = new Color(stat.color.r, g, stat.color.b);
        }
        return stat;
    }
    private StatHolder sizeMutation(StatHolder stat)
    {
        int odd = (int)Random.Range(0, 10);
        float oldSize = stat.size;

        if (odd % 3 == 0)
        {
            stat.size = stat.size + Random.Range(-0.1f, 0.1f);
            float diff = oldSize - stat.size;
            float b =  ((stat.color.b + diff)>1f && (stat.color.b + diff)<0f)?stat.color.b:(stat.color.b + diff);
            stat.color = new Color(stat.color.r, stat.color.g + diff, b);
        }
        return stat;

    }

    private void Mutations(Stats newStat, GameObject newCreature)
    {
        StatHolder stat = new StatHolder(newStat);
        stat = speedMutation(stat);
        stat = sizeMutation(stat);
        stat = healthMutation(stat);
        newStat.updateAll(
          size: stat.size,
          speed: stat.speed,
          health: stat.health,
          color: stat.color,
          timeToReproduce: stat.timeToReproduce
        );

    }
}
