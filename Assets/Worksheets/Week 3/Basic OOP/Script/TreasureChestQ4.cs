using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureChestQ4
{
    public void Unlock()
    {
        Debug.Log("You unlock the chest normally.");
    }

    public void Unlock(bool hasToken)
    {
        if (hasToken)
        {
            Debug.Log("You unlock the chest with a special token! Bonus treasure!");
        }
        else
        {
            Debug.Log("You unlock the chest normally.");
        }
    }
}
