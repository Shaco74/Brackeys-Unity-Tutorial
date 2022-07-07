using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private PlayerMovement playerMovement;
    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.tag == "Obstacle")
        {
            //playerMovement.forwardForce = 0f;
            playerMovement.enabled = false;
        }
    }
}
