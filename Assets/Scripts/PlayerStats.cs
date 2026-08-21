using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerStatSheet
{
    public float health;
    public float movementSpeed;
    public float attackDamage;
    public float attackSpeed; //how much till next attack
}
public class PlayerStats : MonoBehaviour
{


    public PlayerStatSheet statSheet;
    


    void Awake()
    {
        statSheet = new PlayerStatSheet();
        //default values for testing
        statSheet.health = 100f;
        statSheet.movementSpeed = 2f;
        statSheet.attackDamage = 25f;
        statSheet.attackSpeed = 0.8f;
    }

}
