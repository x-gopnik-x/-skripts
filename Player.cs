using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 100;
    public int coin = 0;

    public void TakeDamage(int damage)
    {
        health -= damage;
        print ("здоровье игрока" + health);
    }



    

   
}
