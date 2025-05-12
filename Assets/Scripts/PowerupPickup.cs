using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupPickup : MonoBehaviour
{
    // Start is called before the first frame update
void OnTriggerEnter2D(Collider2D col)
{
    ActivatePowerup();
}
void ActivatePowerup()
{
    Debug.Log("Pickup worked!");
    
    //Give an effect to our player

    //Destroy the pickup

    Destroy(gameObject);
}
}
