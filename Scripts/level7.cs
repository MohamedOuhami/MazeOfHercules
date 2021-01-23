using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level7 : MonoBehaviour
{
    // In total there are 5 traps and 5 keys each key opens a specific door

    // Variables 

    public GameObject door1, door2, door3, door4, door5;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("key1"))
        {
            door1.SetActive(false);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("key2"))
        {
            door2.SetActive(false);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("key3"))
        {
            door3.SetActive(false);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("key4"))
        {
            door4.SetActive(false);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("key5"))
        {
            door5.SetActive(false);
            Destroy(collision.gameObject);
        }
    }
}
