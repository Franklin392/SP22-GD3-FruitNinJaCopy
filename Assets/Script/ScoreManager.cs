using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text scoreText;
    public Text Health;
    int score = 0;
    int LifeNumber = 0;


    public GameObject TextTime;
    public int TimeLeft = 80;
    public bool takingAway = false;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        scoreText.text = score.ToString() + "Points";
        Health.text = "Missing Fruit:" + LifeNumber.ToString() + "/3";

        TextTime.GetComponent<Text>().text = "Time Left:" + TimeLeft;
        StartCoroutine(TimerTake());
    }

    public void AddPoint()
    {
        score += 1;
        scoreText.text = score.ToString() + "Points";
    }

    public void LosePoint()
    {
        LifeNumber += 1;
        Health.text = Health.text = "Missing Fruit:" + LifeNumber.ToString() + "/3";

        if (LifeNumber >=3)
        {
            SceneManager.LoadScene(1);
        }
    }

    void Update()
    {
        if (takingAway == false && TimeLeft > 0)
        {
            StartCoroutine(TimerTake());
        }
        if (TimeLeft <= 0)
        {
            SceneManager.LoadScene(1);
        }
    }
    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        TimeLeft -= 1;
        TextTime.GetComponent<Text>().text = "Time Left:" + TimeLeft;
        takingAway = false;
        if (TimeLeft <= 0)
        {
            SceneManager.LoadScene(1);
        }
    }
}
