using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exitLevel : MonoBehaviour
{
    public GameObject Player;
    public GameObject key;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player && key.GetComponent<openDoor>().collected == true)
        {
            LevelManager.Instance.Win();
            SceneManager.LoadScene("LevelSelect");
        }
    }
}
