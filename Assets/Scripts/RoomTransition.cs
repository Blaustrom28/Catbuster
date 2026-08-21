using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class RoomTransition : MonoBehaviour
{
    
    GameObject door;
    


    
    // Start is called before the first frame update
    void Start()
    {
        door = GameObject.Find("DoorTest");
        
        
    }

   
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == door) 
        {
            
        }
    }
}
