using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    // When pressing play, start the game
    public GameObject SettingsMenu, Instructions;
    public GameObject mainmenu;
    public Slider volumeslider;
    public AudioSource volumeAudio;

    private void Start()
    {
        SettingsMenu.SetActive(false);
        Instructions.SetActive(false);
        mainmenu.SetActive(true);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void EnterSettings()
    {
        SettingsMenu.SetActive(true);
        mainmenu.SetActive(false);
    }
    public void Exitsettings()
    {
        SettingsMenu.SetActive(false) ;
        mainmenu.SetActive(true);
    }
    public void EnterInst()
    {
        Instructions.SetActive(true);
        mainmenu.SetActive(false);
    }
    public void ExitInst()
    {
        Instructions.SetActive(false);
        mainmenu.SetActive(true);
    }
    public void ChangeAudio()
    {
        volumeAudio.volume = volumeslider.value;
    }
}
