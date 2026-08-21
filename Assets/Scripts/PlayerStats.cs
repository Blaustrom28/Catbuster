using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerStatSheet
{
    public float health;
    public float movementSpeed;
    public float attackDamage;
}
public class PlayerStats : MonoBehaviour
{


    public playerStatSheet statSheet;
    


    void Awake()
    {
        statSheet = new playerStatSheet();
        //default values for testing
        statSheet.health = 100f;
        statSheet.movementSpeed = 2f;
        statSheet.attackDamage = 25f;
    }

}
