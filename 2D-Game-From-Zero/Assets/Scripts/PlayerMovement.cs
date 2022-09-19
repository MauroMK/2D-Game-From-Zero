using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Platformer.Mauro;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 30f;

    private Controle2D controle;

    private float movimentoX;

    private bool isJumping = false;

    private void Awake()
    {
        controle = GetComponent<Controle2D>();
    }

    void Update()
    {
        movimentoX = Input.GetAxisRaw("Horizontal") * speed;
        if (Input.GetButtonDown("Jump"))
        {
            isJumping = true;
        }
    }

    void FixedUpdate()
    {
        controle.Movimento(movimentoX * Time.deltaTime, isJumping);
        isJumping = false;
    }
}
