using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pasueMenu;
    public bool isPaused;
    void Start()
    {
        pasueMenu.SetActive(false);
    }

    
    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Escape))
    //    {
    //        if (isPaused)
    //        {
    //            ResumeGame();
    //        }
    //        else
    //        {
    //            PauseGame();
    //        }
    //    }
    //}
    public void PauseGame()
    {
        pasueMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    //public void ResumeGame()
    //{
    //    pasueMenu.SetActive(false);
    //    Time.timeScale = 1f;
    //    isPaused = false;
    //}
}
