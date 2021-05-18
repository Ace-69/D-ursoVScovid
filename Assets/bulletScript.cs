using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour{
    public float speed = 50f;
    public float ATK = 50f;
    public Rigidbody2D rb;

    void Update(){
        rb.velocity = - transform.right * speed;   
        ATK = TextController.ATK;
    }

    void OnTriggerEnter2D(Collider2D other) {
        Enemy enemy = other.GetComponent<Enemy>();
        if(enemy != null) enemy.Damage(ATK); else
        if(other.name == "FR(Clone)") {
            TextController.FireRate -= 0.005f;
            Destroy(other.gameObject);
        } else if(other.name == "ATK(Clone)") { 
            Destroy(other.gameObject);
            TextController.ATK += 20;
        }
        if(!(other.name == "player" || other.name == "bullett(Clone)" || other.name == "walls"))
            Destroy(gameObject); 
    }
}
