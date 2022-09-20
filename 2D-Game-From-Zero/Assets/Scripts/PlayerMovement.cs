using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Platformer.Mauro;
using System;

public class PlayerMovement : MonoBehaviour
{
    #region Variáveis
    [SerializeField]
    private float speed = 30f;
    private float movimentoX;

    private bool isJumping = false;

    private Controle2D controle;

    private Animator animator;

    private Rigidbody2D rb;

    #endregion

    private void Awake()
    {
        controle = GetComponent<Controle2D>();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        movimentoX = Input.GetAxisRaw("Horizontal") * speed;

        if (Input.GetButtonDown("Jump"))
        {
            isJumping = true;
        }

        if (controle.GetEstaNoChao())
        {
            animator.SetFloat("run", Mathf.Abs(rb.velocity.x));
            animator.SetBool("jump", false);
        }
        else
        {
            animator.SetBool("jump", true);
        }
    }

    void FixedUpdate()
    {
        controle.Movimento(movimentoX * Time.deltaTime, isJumping);
        isJumping = false;
    }
}
