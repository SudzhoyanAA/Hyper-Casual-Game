using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class losemenu : MonoBehaviour
{
    public bool losemenu;
    public GameObject pauseGameMenu;

    public void Reset()
    {
        pauseGameMenu.setActive(false);
        Time.timeScale = 1f;
        losemenu = false;
    }
    public void Pause()
    {
        pauseGameMenu.SetActive(true);
        Time.timeScale = 0f;
        losemenu = true;
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }


}
