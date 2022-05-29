using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
   public int maxHealth = 8;
   public int currentHealth; 
   public HealthbarScript healthBar;
   public int damage;


   void Start()
   {
       currentHealth = maxHealth;
       healthBar.SetMaxHealth(maxHealth);
   }

   void Update()
   {

   }

   void TakeDamage(int damage) 
   {
       currentHealth -= damage; 

       healthBar.SetHealth(currentHealth);
   }
   void OnCollisionEnter(Collision collisionInfo)
   {
       if(collisionInfo.gameObject.tag =="Enemy")
       {
           TakeDamage(damage);
       }
       if(collisionInfo.gameObject.tag =="Water")
       {
           TakeDamage(maxHealth);
       }
   }
}