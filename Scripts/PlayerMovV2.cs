using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovV2 : MonoBehaviour
{
    /*
     This will be the 2nd version of my player movement
    ChangeLog :
     1- Work with the trigger methoid instead of the collision to preent any change in my velocity or speed variable
     2- Minimize the lines of code to enhance performance

     */

    // variables
    Rigidbody2D rb;
    Vector3 v;
    GameObject timeobject;
    public Timer timescript;
    public AudioClip powerup, death, nextlevel;
    public AudioSource audio;

    private void Start()
    {
        timeobject = GameObject.FindGameObjectWithTag("TimeObject");
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector3(2f, 0f, 0f);
        timescript = timeobject.GetComponent<Timer>();

    }
    private void FixedUpdate()
    {
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Changing direction
        if (collision.gameObject.CompareTag("Left"))
        {
            rb.velocity = new Vector3(-2f, 0, 0);
        }
        else if (collision.gameObject.CompareTag("Right"))
        {
            rb.velocity = new Vector3(2, 0, 0);
        }
        else if (collision.gameObject.CompareTag("Up"))
        {
            rb.velocity = new Vector3(0, 2, 0);
        }
        else if (collision.gameObject.CompareTag("Down"))
        {
            rb.velocity = new Vector3(0, -2, 0);
        }

        // Player Death

        if (collision.gameObject.CompareTag("Wall"))
        {
            Destroy(this.gameObject);
            audio.clip = death;
            audio.Play();
            audio.loop = false;
            SceneManager.LoadScene(0);

        }
        if (collision.gameObject.CompareTag("Trap"))
        {
            Destroy(this.gameObject);
            audio.clip = death;
            audio.Play();
            audio.loop = false;
            SceneManager.LoadScene(0);
        }
        // Power-ups
        // Speed
        if (collision.gameObject.CompareTag("Speed"))
        {
            v = rb.velocity;
            if (v.x == 0)
            {
                v.y *= 2;
                rb.velocity = v;
                Destroy(collision.gameObject);
            }
            else if (v.y == 0)
            {
                v.x *= 2;
                rb.velocity = v;
                Destroy(collision.gameObject);
            }
            audio.clip = powerup;
            audio.Play();
            audio.loop = false;
        }

            // Add Time
        if (collision.gameObject.CompareTag("Time"))
        {
            timescript.timeRemaining += 10;
            Debug.Log("Add time");
            Destroy(collision.gameObject);
            audio.clip = powerup;
            audio.Play();
            audio.loop = false;

        }

            // Slow down  player
        if (collision.gameObject.CompareTag("DecreaseSpeed1"))
        {
            rb.velocity = new Vector3(1f, 0f, 0f);
        }
        else if (collision.gameObject.CompareTag("DecreaseSpeed2"))
        {
            rb.velocity = new Vector3(.25f, 0f, 0f);
        }
        else if (collision.gameObject.CompareTag("DecreaseSpeed1"))
        {
            rb.velocity = new Vector3(0f, 0f, 0f);
        }

           // Next level
           if (collision.gameObject.CompareTag("Finish"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            audio.clip = nextlevel;
            audio.Play();
            audio.loop = false;
        }
    }
}
