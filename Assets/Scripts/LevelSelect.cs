using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{

    //Buttons
    public void on1click()
    {
        SceneManager.LoadScene("Level_1");
    }
    public void on3click()
    {
        SceneManager.LoadScene("Level_3");
    }
    public void onBackclick()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
