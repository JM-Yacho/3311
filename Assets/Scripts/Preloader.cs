using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Preloader : MonoBehaviour
{

    private CanvasGroup fadeGroup;
    private float loadtime;
    private float minimumlogotime = 4.0f; //Minimum time of team number scene

    // Start is called before the first frame update
    private void Start()
    {
        //Get the only canvas group in the scene
        fadeGroup = FindObjectOfType<CanvasGroup>();

        //Start with a white screen
        fadeGroup.alpha = 1;

        //preload the game
        //HERE

        //Get time of compilation. if it is too fast, give it a small buffer.
        if (Time.time < minimumlogotime)
            loadtime = minimumlogotime;
        else
            loadtime = Time.time;
          

    }

    // Update is called once per frame
    private void Update()
    {
        //Fade in
        if (Time.time < minimumlogotime)
        {
            //Still fading in
            fadeGroup.alpha = 1 - Time.time;
        }

        //Fade out
        if (Time.time > minimumlogotime && loadtime !=0)
        {
            fadeGroup.alpha = Time.time - minimumlogotime;
            if (fadeGroup.alpha >= 1)
            {
                SceneManager.LoadScene("MainMenu");
            }
        }
    }
}
