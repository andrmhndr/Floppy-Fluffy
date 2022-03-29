using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameplay : MonoBehaviour
{
    public bool isPaused = true;
    public bool isOver = false;

    [SerializeField]
    private TextMeshProUGUI scoreText;

    [SerializeField]
    private TextMeshProUGUI scoreTextFinal;

    public GameObject gameOverObject;

    public GameObject player;

    private int score;

    public TextMeshProUGUI timeText;

    private void Start()
    {
        Time.timeScale = 0f;
        gameStart();
    }
    private void Update()
    {
        if (!isOver)
        {
            score = player.GetComponent<player>().score;
            scoreText.SetText("Score : " + score);
            scoreTextFinal.SetText("Total Score: " + score);

            player.GetComponent<player>().isPaused = isPaused;

            isOver = player.GetComponent<player>().isOver;
        }
        else
        {
            Time.timeScale = 0f;
            gameOverObject.SetActive(true);
        }
    }

    public void gamePaused()
    {
        isPaused = true;
        Time.timeScale = 0f;
    }

    public void gameContinue()
    {
        gameStart();
    }
    public void gameStart()
    {
        StartCoroutine(delay());
    }

    IEnumerator delay()
    {
        timeText.SetText("3");
        yield return new WaitForSecondsRealtime(1);
        timeText.SetText("2");
        yield return new WaitForSecondsRealtime(1);
        timeText.SetText("1");
        yield return new WaitForSecondsRealtime(1);
        timeText.SetText("Start!");
        yield return new WaitForSecondsRealtime(1);
        timeText.SetText("");
        Time.timeScale = 1f;
        isPaused = false;
    }
}
