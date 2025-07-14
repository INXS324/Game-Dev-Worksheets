using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MainQ4 : MonoBehaviour
{
    void Start()
    {
        TreasureChestQ4 chest = new TreasureChestQ4();

        chest.Unlock();        
        chest.Unlock(true);    
        chest.Unlock(false);   
    }
}


