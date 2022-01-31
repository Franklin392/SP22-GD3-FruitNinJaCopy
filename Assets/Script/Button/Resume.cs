using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resume : MonoBehaviour
{
    public GameObject pasueMenu;
    public bool isPaused;
    void Start()
    {
        //pasueMenu.SetActive(false);
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ResumeGame()
    {
        pasueMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
}
