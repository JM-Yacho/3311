using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFollow : MonoBehaviour
{
    public GameObject Player;
    private float MoveSpeed = 1.2f;
    private float MinDist = 0;
    private float MaxDist = 15;

    void Start()
    {

    }

    void Update()
    {
        transform.LookAt(Player.transform);
        if (Player.transform.position.x >= -77.5 && Player.transform.position.x <= -59.5 && Player.transform.position.y >= .75 && Player.transform.position.y < 1.5)
        {
            if (Vector2.Distance(transform.position, Player.transform.position) >= MinDist && Vector2.Distance(transform.position, Player.transform.position) <= MaxDist)
            {
                transform.position += transform.forward * MoveSpeed * Time.deltaTime;
            }
        }
    }
}

