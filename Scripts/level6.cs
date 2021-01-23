using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level6 : MonoBehaviour
{
    // In order for the player to get to the finish line, he needs to get the key to unlock the gate ( trap )

    // Variables :
    public GameObject trap;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("key"))
        {
            trap.SetActive(false);
            Destroy(collision.gameObject);
        }
    }
}
