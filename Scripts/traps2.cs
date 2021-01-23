using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class traps2 : MonoBehaviour
{
    public GameObject deactivatedtrap;
    public GameObject trap1;
    public GameObject trap2;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            deactivatedtrap.SetActive(true);
            trap1.SetActive(false);
            trap2.SetActive(false);
        }
    }
}
