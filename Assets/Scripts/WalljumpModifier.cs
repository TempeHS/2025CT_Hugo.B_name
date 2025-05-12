using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalljumpModifier : PowerupModifier

{
    private bool isWallSliding;
    private float WallSlidingSpeed = 2f;
    [SerializeField] private Transform wallCheck;
    [SerializeField] private layerMask wallLayer;
    
    private bool isWalled()
    {
        return Physics2D.OverlapCircle(wallCheck.position, 0.2f, wallLayer);
    }

    private void WallSlide()
    {
        if (isWalled() && !IsGrounded() && horizontal != 0f)
        {
            isWallSliding = true;
            //1:48 of video
        }
    }
    public override void Activate(GameObject target)
    {

    }
}
