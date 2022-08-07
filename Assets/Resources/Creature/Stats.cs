using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class Stats : MonoBehaviour
{
    // Start is called before the first frame update
    
     public List<string> Mutations;
     public Color color;

     public int Generation;
     public int Group;
     public float speed;
     public float health;

    public float timeToReproduce;
    public float timeToDeath;
    public bool destroyed ;

    // It will cost 0.01f for each unit speed and 0.05f for each unit size.
    // public float costOfMotion=0;

     public float size;
     

     private void Awake() {
            Mutations = new List<string>();
            destroyed = false;
     }  

    public void updateAll(Color color, float speed, float health, float size, float timeToReproduce, float timeToDeath){
        updateColor(color);
        updateSpeed(speed);
        updateHealth(health);
        updateSize(size);
        updateTimeToReproduce(timeToReproduce);
        updateTimeToDeath(timeToDeath);
    }

public void destroy(){
    destroyed = true;
}
     public void updateColor(Color color)
     {

         this.color = color;
         gameObject.GetComponent<SpriteRenderer>().color = color;
         Mutations.Add("Color = " + color);

     }
        public void updateSpeed(float speed)
        {

            this.speed = speed;
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.value, Random.value) * speed;
            Mutations.Add("Speed = " + speed);
        }
        public void updateSize(float size)
        {                

            this.size = size;
            gameObject.transform.localScale = new Vector2(0.1f, 0.1f) * size;
            gameObject.GetComponent<Rigidbody2D>().mass = size;
            Mutations.Add("Size = " + size);
        }
        public void updateHealth(float health)
        {
            this.health = health;
            Mutations.Add("Health = " + health);
        }

        public void updateGeneration(int Generation)
        {
            this.Generation = Generation;


        }
        public void updateGroup(int Group)
        {
            this.Group = Group;
        }
        public void updateTimeToReproduce(float timeToReproduce)
        {
            this.timeToReproduce = timeToReproduce;
            Mutations.Add("TimeToReproduce = " + timeToReproduce);
        }
        public void updateTimeToDeath(float timeToDeath)
        {
            this.timeToDeath = timeToDeath;
            Mutations.Add("TimeToDeath = " + timeToDeath);
        }

     
   
}
