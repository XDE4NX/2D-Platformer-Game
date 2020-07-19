using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levelovercontroler : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<Playercontroller>() != null)
        {
            Debug.Log("level complete");
            ReloadLevel();
        }
    }

    private void ReloadLevel()
    {
        SceneManager.LoadScene(1);
    }
}
