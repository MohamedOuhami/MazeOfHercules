using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class traps : MonoBehaviour
{
    // Use raycasting to detect If the player gets near the trap
    // If the trap was active, deactivate It
    // Otherwise, activate It


    // Variables
    //public GameObject[] traparray;
    public GameObject trapprimary;
    public GameObject trapsecondary;

    private void Start()
    {
        //traparray = GameObject.FindGameObjectsWithTag("Trap");
    }
    // Detecting player
    private void FixedUpdate()
    {
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (trapprimary.activeSelf == true)
        {
            trapprimary.SetActive(false);
            trapsecondary.SetActive(true);
        }
        else
        {
            trapprimary.SetActive(true);
            trapsecondary.SetActive(false);
        }
    }
}
