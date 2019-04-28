using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelData
{
    public levelData(string levelname)
    {
        string data = PlayerPrefs.GetString(levelname);
        if (data == "")
            return;
        string[] alldata = data.Split('&');
        BestTime = float.Parse(alldata[0]);

    }
    public float BestTime { set;get;  }
}

public class LevelSelect : MonoBehaviour
{
    public GameObject levelbutton;
    public GameObject levelbuttonContainer;

    private void Start()
    {
        Sprite[] thumbnails = Resources.LoadAll<Sprite>("Levels");
        foreach (Sprite thumbnail in thumbnails)
        {
            GameObject container = Instantiate(levelbutton) as GameObject;
            container.transform.SetParent(levelbuttonContainer.transform, false);
            container.transform.GetChild(0).GetComponent<Image>().sprite = thumbnail;
            container.transform.GetChild(0).GetChild(0).GetComponent<Text>().text = thumbnail.name;
            levelData level = new levelData(thumbnail.name);
            container.transform.GetChild(1).GetChild(0).GetComponent<Text>().text = level.BestTime.ToString("f"); //Gets Best Time panel text component

            string Scenename = thumbnail.name;
            container.GetComponent<Button>().onClick.AddListener(() => LoadLevel(Scenename));
        }
    }

    //Buttons
    private void LoadLevel(string Scenename)
    {
        SceneManager.LoadScene(Scenename);
    }
    public void onBackclick()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
