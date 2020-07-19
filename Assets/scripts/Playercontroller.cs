using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playercontroller : MonoBehaviour
{
    public ScoreController ScoreController;
    public GameOverController gameOverController;
    public Animator animator;

    public float speed;
    public float jump;

    private Rigidbody2D rig2d;

    public void Awake()
    {
        Debug.Log("Player collison Awake");
        rig2d = gameObject.GetComponent<Rigidbody2D>();
    }

    public void KillPlayer()
    {
        Debug.Log("killed");
        //Destroy(gameObject);
        gameOverController.PlayerDied();
        this.enabled = false;
    }


    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Jump");
       
        MoveCharacter(horizontal, vertical);
        PlayMovementAnimation(horizontal, vertical);
    }

    public void PickUpKey()
    {
        Debug.Log("Key Found");
        ScoreController.IncreaseScore(25);
    }

    private void MoveCharacter(float horizontal, float vertical)
    {
        Vector3 position = transform.position;
        position.x += horizontal * speed * Time.deltaTime;
        transform.position = position;

        if(vertical > 0)
        {
            rig2d.AddForce(new Vector2(0f, jump), ForceMode2D.Force);
        }
    }

    private void PlayMovementAnimation(float horizontal, float vertical)
    {
        animator.SetFloat("Speed", Mathf.Abs(horizontal));
        Vector3 scale = transform.localScale;
        if (horizontal < 0)
        {
            scale.x = -1f * Mathf.Abs(scale.x);
        }
        else if (horizontal > 0)
        {
            scale.x = Mathf.Abs(scale.x);
        }
        transform.localScale = scale;

        // Jump
        if (vertical > 0)
        {
            animator.SetBool("Jump", true);
        }
        else
        {
            animator.SetBool("Jump", false);
        }

    }
}
