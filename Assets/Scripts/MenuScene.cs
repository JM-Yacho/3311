using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScene : MonoBehaviour
{
    private CanvasGroup fadeGroup;
    private float fadeinspeed = 2f;

    


    // Start is called before the first frame update
    private void Start()
    {
        //Get the only canvas group in the scene
        fadeGroup = FindObjectOfType<CanvasGroup>();

        //Start with a white screen
        fadeGroup.alpha = 1;

       
    }

    // Update is called once per frame
    private void Update()
    {
        //Fading in
        fadeGroup.alpha = 1 - Time.timeSinceLevelLoad * fadeinspeed;

    }

    //Buttons
    public void onPlayclick()
    {
        SceneManager.LoadScene("LevelSelect");
    }
    public void onShopclick()
    {
        
        SceneManager.LoadScene("ShopMenu");
    }
}
