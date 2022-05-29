using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject Player;
    public float Speed;
    public bool Paused;

    public PlayerXP playerxp;


   
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        playerxp = Player.GetComponent<PlayerXP>();
           
    }

    // Update is called once per frame
     void Update()
    {

        Paused = playerxp.MenuActive;

      

        if (playerxp.MenuActive == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, Speed);
            print("MovingTowards");
        }
    }
}
