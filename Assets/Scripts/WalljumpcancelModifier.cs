using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalljumpcancelModifier : MonoBehaviour
{
    private float jumpingPower = 10f;

    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D col)
{
    ActivatePowerupCancel();
}
void ActivatePowerupCancel()
{
    Debug.Log("Pickup worked!");

        jumpingPower *= 100f;

    //Destroy the pickup

    Destroy(gameObject);
}
}