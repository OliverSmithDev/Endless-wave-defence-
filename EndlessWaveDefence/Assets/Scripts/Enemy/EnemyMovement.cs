using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject Player;
    public float Speed;

    public PlayerXP playerxp;


   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        Player = GameObject.FindGameObjectWithTag("Player");

        if (playerxp.MenuActive == false)
        {
       
            transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, Speed);
            print("MovingTowards");
        }
              
    }
}
