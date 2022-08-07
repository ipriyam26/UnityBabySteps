using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mutation : MonoBehaviour
{
    // Start is called before the first frame update
public class StatHolder{
    public Color color;
    public float speed;
    public float health;
    public float size;
    public float timeToDeath;
     public float timeToReproduce;

    public StatHolder(Stats stat){
        this.color = stat.color;
        this.speed = stat.speed;
        this.health = stat.health;
        this.size = stat.size;
        this.timeToDeath = stat.timeToDeath;
        this.timeToReproduce = stat.timeToReproduce;
    }
     
}

  private void Awake() {
    Stats stat = gameObject.GetComponent<Stats>();
    Mutations(stat,gameObject);
  } 


    private StatHolder timeMutation( StatHolder stat )
    {
        int odd = (int)Random.Range(0, 10);
        if(odd%3==0){

        stat.timeToDeath = stat.timeToDeath + Random.Range(-0.1f, 0.1f);
        }
        if(odd%4==0){
        stat.timeToReproduce = stat.timeToReproduce + Random.Range(-0.1f, 0.1f);
        }
        return stat;
    }
    private  StatHolder colorMutation(StatHolder stat)
    {
     int odd = (int)Random.Range(0,10);
     if(odd%3==0){
        stat.color = new Color(Random.Range(0.0f,1.0f),Random.Range(0.0f,1.0f),Random.Range(0.0f,1.0f));
     }
      return stat;
    }
    private  StatHolder speedMutation(StatHolder stat)
    {
     int odd = (int)Random.Range(0,10);
     if(odd%3==0){
        stat.speed = stat.speed + Random.Range(-0.1f,0.1f);
     }
      return stat;
        
    }
    private  StatHolder sizeMutation(StatHolder stat)
    {
     int odd = (int)Random.Range(0,10);
     if(odd%3==0){
        stat.size = stat.size + Random.Range(-0.1f,0.1f);
     }
      return stat;
        
    }
    private StatHolder  healthMutation(StatHolder stat)
    {
     int odd = (int)Random.Range(0,10);
     if(odd%3==0){
        stat.health = stat.health + Random.Range(-0.1f,0.1f);
     }
      return stat;
    }

  private void Mutations(Stats newStat, GameObject newCreature)
    {
        StatHolder stat = new StatHolder(newStat);
        stat = timeMutation(stat);
        stat = colorMutation(stat);
        stat = speedMutation(stat);
        stat = sizeMutation(stat);
        stat = healthMutation(stat);
        newStat.updateAll(stat.color,stat.speed,stat.health,stat.size,stat.timeToDeath,stat.timeToReproduce);

    }
}
