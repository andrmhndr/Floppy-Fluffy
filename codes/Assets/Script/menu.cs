using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{

    private void Start()
    {
        Time.timeScale = 1f;
    }
    public void startGame()
    {
        SceneManager.LoadScene("Arena");
    }

    public void quit()
    {
        Application.Quit();
    }
}
