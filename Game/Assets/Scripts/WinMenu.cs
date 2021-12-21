using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public void MenuGame()
    {
        SceneManager.LoadScene(0);
    }

    public void ResetGame()
    {
        SceneManager.LoadScene(1);
    }
}
