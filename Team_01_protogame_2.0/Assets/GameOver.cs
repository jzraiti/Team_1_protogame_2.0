using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Justin's Menu", LoadSceneMode.Single);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

}
