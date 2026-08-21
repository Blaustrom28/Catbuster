using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackSpawn : MonoBehaviour
{

    GameObject attackBox;
    float attackCoolDown;
    float timer;
    PlayerStats playerStats;

    // Start is called before the first frame update
    void Start()
    {
        playerStats = GetComponentInParent<PlayerStats>();
        attackBox = GameObject.Find("Attack");
        attackCoolDown = playerStats.statSheet.attackSpeed;
        timer = attackCoolDown;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;



        if (timer >= attackCoolDown)
        {
            if (Input.GetMouseButtonDown(0))
            {
                GameObject attackActive = Instantiate(attackBox);
                attackActive.transform.position = transform.position;
                attackActive.transform.rotation = transform.rotation;
                attackActive.tag = "Attacks";
                timer = 0f;
            }

            
        }
        
    }
}
