using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levelovercontroler : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<Playercontroller>() != null)
        {
            Debug.Log("level complete");
        }
    }
}
