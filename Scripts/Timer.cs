using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeRemaining;
    public bool timerIsRunning = false;
    public Text timeText;
    public GameObject player;
    float minutes;
    public float seconds;

    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
        timeRemaining = 30;
        timeText = GameObject.FindGameObjectWithTag("Timetext").GetComponent<Text>() ;
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                minutes = Mathf.FloorToInt(timeRemaining / 60);
                seconds = Mathf.FloorToInt(timeRemaining % 60);
                DisplayTime();
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
                Destroy(player.gameObject);
                SceneManager.LoadScene(0);
            }
        }
    }

    void DisplayTime()
    {
        if (minutes < 0 || seconds < 0)
        {
            minutes = 0;
            seconds = 0;
        }
        timeText.text = string.Format("{0:00}:{1,00}", minutes, seconds);
    }

}