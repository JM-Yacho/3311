using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private static LevelManager instance;
    public static LevelManager Instance { get { return instance; } }
    public GameObject PauseMenu;
    private float starttime;
    public float silvertime;
    public float goldtime;

    private void Start()
    {
        instance = this;
        PauseMenu.SetActive(false);
        starttime = Time.time;
    }

    public void TogglePause()
    {
        PauseMenu.SetActive(!PauseMenu.activeSelf);
    }

    public void ToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void ToLevelSelect()
    {
        SceneManager.LoadScene("LevelSelect");
    }
    public void Win()
    {
        //Code for win
        float duration_of_level = Time.time - starttime;
        string save = "";
        //"00:40"
        save += duration_of_level.ToString();
        PlayerPrefs.SetString(SceneManager.GetActiveScene().name, save);
        SceneManager.LoadScene("MainMenu");

      
    }
}
