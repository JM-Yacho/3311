using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exit_1Key : MonoBehaviour
{
    public GameObject Player;
    public GameObject key;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player && key.GetComponent<collectKey>().collected == true)
        {
            LevelManager.Instance.Win();
        }
    }
}
