using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicChest : TreasureChest
{
    public override void Unlock()
    {
        Debug.Log("You cast a spell to unlock the magic chest.");
    }
}

