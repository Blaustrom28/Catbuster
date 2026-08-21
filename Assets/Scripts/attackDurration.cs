using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackDurration : MonoBehaviour
{
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("AttackingPoint");
        if (gameObject.tag == "Attacks")
        {

            transform.parent = player.transform;
            
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        if(gameObject.tag == "Attacks")
        {

            Destroy(gameObject,.1f);
        }
    }
}
