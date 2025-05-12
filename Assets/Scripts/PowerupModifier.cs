using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerupModifier : ScriptableObject
{
    // Start is called before the first frame update
    public abstract void Activate(GameObject target);

}
