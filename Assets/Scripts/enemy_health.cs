using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class enemy_health : MonoBehaviour
{

    float health = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

/*
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "attack")
        {
            decreaseHealth(attackSpawn.damage);
        }
    }
*/

    void decreaseHealth(float damage)
    {
        health -= damage;
        print($"enemy health: {health}");

        if(health <= 0)
        {
            death();
        }
    }

    void death(){
        Destroy(gameObject);
    }
}