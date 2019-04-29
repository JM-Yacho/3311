using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScene : MonoBehaviour
{
    public GameObject instrucPopup;

    private void Start()
    {
        instrucPopup.SetActive(false);
    }


    //Buttons
    public void Toggleinstr()
    {
        instrucPopup.SetActive(!instrucPopup.activeSelf);
    }
    public void onPlayclick()
    {
        SceneManager.LoadScene("LevelSelect");
    }
    public void onShopclick()
    {
        
        SceneManager.LoadScene("ShopMenu");
    }
}
