using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<Playercontroller>() != null)
        {
            Playercontroller playercontroller = collision.gameObject.GetComponent<Playercontroller>();
            playercontroller.PickUpKey();
            Destroy(gameObject);

        }
    }
}
