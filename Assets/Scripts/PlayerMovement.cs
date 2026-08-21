using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //determines how fast the player walkes
    private float playerSpeed;

    PlayerStats playerStats;
    
    void Start()
    {
        playerStats = GetComponent<PlayerStats>();
        
        playerSpeed = playerStats.statSheet.movementSpeed;
    }

    
    
    void Update()
    {


            //wasd Movement handled by unity (most fancy version)
            float x = Input.GetAxisRaw("Horizontal");
            float y = Input.GetAxisRaw("Vertical");

            Vector3 movement = new Vector3(x, y, 0).normalized;

            transform.position += movement * playerSpeed * Time.deltaTime;
        

    }
}
