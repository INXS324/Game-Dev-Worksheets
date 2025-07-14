using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    void Start()
    {
        Projectile p1 = new Projectile(20);
        p1.Fire();

        Projectile p2 = new Projectile(0);
        p2.Fire();

        Player player = new Player(10);
        player.TakeDamage(3);
        Debug.Log("Player health after taking 3 damage: " + player.GetHealth());

        player.TakeDamage(10);
        Debug.Log("Player health after taking 10 more damage: " + player.GetHealth());

        ScoreTracker tracker = new ScoreTracker();



    }
}

