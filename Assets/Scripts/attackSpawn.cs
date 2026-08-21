using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackSpawn : MonoBehaviour
{

    GameObject attackBox;

    // Start is called before the first frame update
    void Start()
    {
        attackBox = GameObject.Find("Attack");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject attackActive = Instantiate(attackBox);
            attackActive.transform.position = transform.position;
            attackActive.transform.rotation = transform.rotation;
            attackActive.tag = "Attacks";
        }
    }
}
