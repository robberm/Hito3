using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    //STATS;
    private int playerHealth;
    private int enemyHealth;
   public Health(){
        this.playerHealth = 100;
        this.enemyHealth = 20;

    }
    public int getPlayerHealth(){ return playerHealth; }
    


}
