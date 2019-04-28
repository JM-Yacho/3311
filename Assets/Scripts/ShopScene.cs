using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ShopScene : MonoBehaviour
{
    public GameObject shopButtonPrefab;
    public GameObject shopButtonContainer;
    public Material playerMaterial;

    // Start is called before the first frame update
    public void Start()
    {
        
        int skinindex = 0;
        //Getting player skins
        Sprite[] skins = Resources.LoadAll<Sprite>("Player");
        foreach (Sprite skin in skins)
        {
            GameObject container = Instantiate(shopButtonPrefab) as GameObject;
            container.GetComponent<Image>().sprite = skin;
            container.transform.SetParent(shopButtonContainer.transform, false);
            int index = skinindex;
            container.GetComponent<Button>().onClick.AddListener(() => ChangePlayerSkin(index));
            skinindex++;
        }
    }

    // Update is called once per frame
    public void Update()
    {
        
    }
    public void onBackClick()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void ChangePlayerSkin(int index)
    {
        float x = (index % 4) * 0.25f;
        float y = ((int)index / 4) * 0.25f;

        //Fixing indexing problem for colors
        if (y == 0.0f)
            y = 0.75f;
        else if (y == 0.25f)
            y = 0.5f;
        else if (y == 0.50f)
            y = 0.25f;
        else if (y == 0.75f)
            y = 0f;

        playerMaterial.SetTextureOffset("_MainTex", new Vector2(x, y));
    }
}
