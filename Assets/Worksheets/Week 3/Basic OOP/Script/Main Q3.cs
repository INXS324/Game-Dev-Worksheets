using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MainQ3 : MonoBehaviour
{
    void Start()
    {
        TreasureChest normalChest = new TreasureChest();
        AncientChest ancientChest = new AncientChest();
        MagicChest magicChest = new MagicChest();

        normalChest.Unlock();
        ancientChest.Unlock();
        magicChest.Unlock();

        normalChest.Shake();
        ancientChest.Shake();
        magicChest.Shake();
    }
}
