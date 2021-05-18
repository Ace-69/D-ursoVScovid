using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour{
    
    private Vector3 mouse_pos;
    public Transform target;
    private Vector3 object_pos;
    private float angle;
    
    public float bulletSpeed = 10;
    public Transform firepoint;
    public GameObject bullet;
    public float FireRate = 0.5f;
    float next = 0.0f;
    
    void Start(){
        
    }
    
    void Update(){     
        if(!PauseMenuScript.IsPaused){
            FireRate = TextController.FireRate;  
            mouse_pos = Input.mousePosition;
            mouse_pos.z = -20;
            object_pos = Camera.main.WorldToScreenPoint(target.position);
            mouse_pos.x = -mouse_pos.x + object_pos.x;
            mouse_pos.y = -mouse_pos.y + object_pos.y;
            angle = Mathf.Atan2(mouse_pos.y, mouse_pos.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, angle);
            if (Input.GetButton("Fire1") && (Time.time > next)){
                next = Time.time + FireRate;
                Fire();
            }
        }
    }

    void Fire(){
        Instantiate(bullet, firepoint.position, firepoint.rotation);
    }
}
