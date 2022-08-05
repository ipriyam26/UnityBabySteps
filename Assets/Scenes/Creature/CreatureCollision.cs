using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureCollision : MonoBehaviour
{
    GameObject creature;
    private void Start() {
        creature =   Resources.Load<GameObject>("Creature 1");
    }
private void OnCollisionEnter2D(Collision2D other) {
    
    if (other.gameObject.tag != gameObject.tag){
        DestroyOnCollision(other);
    }
    else{
        MultiplyOnCollision(other);
    }
}

private void DestroyOnCollision(Collision2D other) {
    Destroy(other.gameObject);
}

private void MultiplyOnCollision(Collision2D other) {
    Rigidbody2D otherRigidBody = other.gameObject.GetComponent<Rigidbody2D>();
gameObject.GetComponent<Rigidbody2D>().AddForce(otherRigidBody.velocity *otherRigidBody.velocity);
    GameObject newCreature = Instantiate(creature);
            newCreature.GetComponent<SpriteRenderer>().color =  other.gameObject.GetComponent<SpriteRenderer>().color;
            newCreature.transform.position = gameObject.transform.position;
            newCreature.name  =  gameObject.name + "N";
            newCreature.tag = gameObject.tag;

}

}
