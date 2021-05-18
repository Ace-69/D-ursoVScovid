using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour{
    
    public ParticleSystem particle;
    public GameObject ATK, FR;
    public Transform me;
    TextController Label;
    public float hp = 100f;
    int chanche;
    
    public HealtBar hpbar;

    // Start is called before the first frame update
    void Start(){
        hp = TextController.enemyhp;
        hpbar.setMaxHealt(hp);
    }

    // Update is called once per frame
    void Update(){
    }
    public void Damage(float dmg){
        hp -= dmg;
        hpbar.setHealt(hp);
        if (hp <= 0) Die();
    }
    void Die(){
        chanche = Random.Range(0, 100);
        if(chanche < 10){
            if(TextController.FireRate >= 0.0f){
                chanche = Random.Range(0,2);
                Instantiate(((chanche == 1)?ATK:FR), me.position, me.rotation);
            } else {
                Instantiate(ATK, me.position, me.rotation);
            }
        }
        Instantiate(particle, me.position, me.rotation);
        particle.Play();
        TextController.points += 10;
        particle.Clear();
        Destroy(me.parent.gameObject);
        Destroy(gameObject);
    }
    void OnTriggerEnter2D(Collider2D other) {
        Debug.LogWarning(other.name);
        if(other.name == "player"){
            TextController.Lives--;
            Destroy(me.parent.gameObject);
            Destroy(gameObject);
        }
    }
}
