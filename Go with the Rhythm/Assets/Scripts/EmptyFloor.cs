using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyFloor : MonoBehaviour
{
    PlayerMovement playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        playerMovement = GameObject.FindObjectOfType<PlayerMovement>();
    }

    //On empty floor collision
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            //Kills the player
            playerMovement.speed = 1f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
