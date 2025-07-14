using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureChest
{
    public virtual void Unlock()
    {
        Debug.Log("You unlock the chest.");
    }

    public void Shake()
    {
        Debug.Log("You hear something rattle inside the chest.");
    }
}

