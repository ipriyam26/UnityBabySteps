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

    private StatHolder manageColor( StatHolder stat )
    {

        stat = speedColor(stat);
        stat = sizeColor(stat);

        return stat;
    }

  private StatHolder sizeColor( StatHolder stat ){
    float size = stat.size;
    if(size>=8){
      stat.color = new Color(stat.color.r,stat.color.g,1f);
    }
    else if(size>=7.5f){
      stat.color = new Color(stat.color.r,stat.color.g,0.95f);
    }
    else if(size>=7f){
      stat.color = new Color(stat.color.r,stat.color.g,0.9f);

    }
    else if(size>=6.8f){
      stat.color = new Color(stat.color.r,stat.color.g,0.85f);
    }
    else if(size>=6.6f){
      stat.color = new Color(stat.color.r,stat.color.g,0.8f);
    }
    else if(size>=6.4f){
      stat.color = new Color(stat.color.r,stat.color.g,0.75f);
    }
    else if(size>6.2f){
      stat.color = new Color(stat.color.r,stat.color.g,0.7f);
    }
    else if(size>=6f){
      stat.color = new Color(stat.color.r,stat.color.g,0.65f);
    }
    else if (size>=5.8f){
      stat.color = new Color(stat.color.r,stat.color.g,0.6f);
    }
    else if (size>=5.6f){
      stat.color = new Color(stat.color.r,stat.color.g,0.55f);
    }
    else if (size>=5.4f){
      stat.color = new Color(stat.color.r,stat.color.g,0.5f);
    }
    else if (size>=5.2f){
      stat.color = new Color(stat.color.r,stat.color.g,0.45f);
    }
    else if (size>=5f){
      stat.color = new Color(stat.color.r,stat.color.g,0.4f);
    }
    else if (size>=4.8f){
      stat.color = new Color(stat.color.r,stat.color.g,0.35f);
    }
    else if (size>=4.6f){
      stat.color = new Color(stat.color.r,stat.color.g,0.3f);
    }
    else if (size>=4.5f){
      stat.color = new Color(stat.color.r,stat.color.g,0.25f);
    }
    else if (size>=4.4f){
      stat.color = new Color(stat.color.r,stat.color.g,0.2f);
    }
    else if(size>=4.3f){
      stat.color = new Color(stat.color.r,stat.color.g,0.15f);
    }
    else if (size>=4.2f){
      stat.color = new Color(stat.color.r,stat.color.g,0.1f);
    }
    else if (size>=4.1f){
      stat.color = new Color(stat.color.r,stat.color.g,0.05f);
    }
    
    return stat;
  }
    private  StatHolder speedColor(StatHolder stat)
    {
      float speed = stat.speed;
        if (speed >= 20)
        {
            stat.color = new Color(1f, stat.color.g, stat.color.b);
        }
        else if (speed >= 19)
        {
            stat.color = new Color(0.95f, stat.color.g, stat.color.b);
        }
        else if (speed >= 18)
        {
            stat.color = new Color(0.9f, stat.color.g, stat.color.b);
        }
        else if (speed >= 17)
        {
            stat.color = new Color(0.85f, stat.color.g, stat.color.b);
        }
        else if (speed >= 16)
        {
            stat.color = new Color(0.8f, stat.color.g, stat.color.b);
        }
        else if (speed >= 15.5)
        {
            stat.color = new Color(0.75f, stat.color.g, stat.color.b);
        }
        else if (speed >= 15)
        {
            stat.color = new Color(0.7f, stat.color.g, stat.color.b);
        }

        else if (speed >= 14.9)
        {
            stat.color = new Color(0.6f, stat.color.g, stat.color.b);
        }
        else if (speed >= 14.8)
        {
            stat.color = new Color(0.55f, stat.color.g, stat.color.b);
        }
        else if (speed >= 14.7)
        {
            stat.color = new Color(0.5f, stat.color.g, stat.color.b);
        }
        else if (speed >= 14.6)
        {
            stat.color = new Color(0.45f, stat.color.g, stat.color.b);
        }
        else if (speed >= 14.5)
        {
            stat.color = new Color(0.4f, stat.color.g, stat.color.b);
        }
        else if (speed >= 14.4)
        {
            stat.color = new Color(0.35f, stat.color.g, stat.color.b);
        }
        else if (speed >= 14.3)
        {
            stat.color = new Color(0.3f, stat.color.g, stat.color.b);
        }
        else if (speed >= 14.2)
        {
            stat.color = new Color(0.25f, stat.color.g, stat.color.b);
        }
        else if (speed >= 14.1)
        {
            stat.color = new Color(0.2f, stat.color.g, stat.color.b);
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
        // stat = colorMutation(stat);
        
        stat = speedMutation(stat);
        stat = sizeMutation(stat);
        stat = healthMutation(stat);
        stat = manageColor(stat);
        newStat.updateAll(
          size: stat.size,
          speed: stat.speed,
          health: stat.health,
          color: stat.color,
          timeToReproduce: stat.timeToReproduce,
          timeToDeath: stat.timeToDeath
        );

    }
}
