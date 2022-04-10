using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image healthbar;
    public float currentHealth;
    PlayerProperties player;
    public float maxHealth = 100;


 void Start()
    {
      healthbar = gameObject.GetComponent<Image>();
      
      
    }

    void Update()
    {
        currentHealth = player.playerHealth;
        healthbar.fillAmount = currentHealth / maxHealth; //donde 100 es el maxhealth
    }
}
