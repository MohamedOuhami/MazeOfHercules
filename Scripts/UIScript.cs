using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public GameObject PauseMenu;
    public GameObject SettingsMenu;
    public GameObject[] buttons;
    public Slider volumeslider;
    public AudioSource volumeAudio;
    // When pressing Play, give the player level 1

    void Start()
    {
        PauseMenu.active = false;
        SettingsMenu.active = false;
    }
    public void loadScene()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void Pause()
    {
        Time.timeScale = 0f;
        PauseMenu.active = true;
    }
    public void Unpause()
    {
        Time.timeScale = 1f;
        PauseMenu.active = false;
    }
    public void ReturnMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void EnterSettings()
    {
        foreach (GameObject button in buttons)
        {
            button.active = false;
            SettingsMenu.active = true;
        }
    }
    public void Exitsettings()
    {
        foreach (GameObject button in buttons)
        {
            button.active = true;
            SettingsMenu.active = false;
        }
    }
    public void ChangeAudio()
    {
        volumeAudio.volume = volumeslider.value;
    }
}

