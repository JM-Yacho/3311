using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exit_OneKey : MonoBehaviour
{
    public GameObject Player;
    public GameObject key;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player && key.GetComponent<collectKey>().collected == true)
        {
            SceneManager.LoadScene("LevelSelect");
        }
    }
}
