using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScene : MonoBehaviour
{


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
