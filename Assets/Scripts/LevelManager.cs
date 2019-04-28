using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    private static LevelManager instance;
    public static LevelManager Instance { get { return instance; } }
    public GameObject PauseMenu;
    private float duration_of_level;
    private float starttime;
    public float silvertime;
    public float goldtime;
    public Text timeText;

    private void Start()
    {
        instance = this;
        PauseMenu.SetActive(false);
        starttime = Time.time;
    }
    public void Update()
    {
        duration_of_level = Time.time - starttime;
        string minutes = ((int)duration_of_level / 60).ToString("00");
        string seconds = (duration_of_level % 60).ToString("00.00");
        timeText.text = minutes + ":" + seconds;
    }

    public void TogglePause()
    {
        PauseMenu.SetActive(!PauseMenu.activeSelf);
        Time.timeScale = (PauseMenu.activeSelf) ? 0 : 1;
    }

    public void ToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
    public void ToLevelSelect()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("LevelSelect");
    }
    public void Win()
    {
        //Code for win
        float duration_of_level = Time.time - starttime;
        string save = "";
        levelData level = new levelData(SceneManager.GetActiveScene().name);
        save += (level.BestTime > duration_of_level || level.BestTime == 0.0f) ? duration_of_level.ToString() : level.BestTime.ToString();
        PlayerPrefs.SetString(SceneManager.GetActiveScene().name, save);
        Debug.Log("Finished with time" + save);
        ToLevelSelect();

      
    }
    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
