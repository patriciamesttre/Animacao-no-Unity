using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    SpriteRenderer spritePlayer;
    Animator animacao;

    void Start()
    {
        spritePlayer = GetComponent<SpriteRenderer>();
        animacao = GetComponent<Animator>();
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            animacao.SetBool("Andar", true);
        }
        else
        {
            animacao.SetBool("Andar", false);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * 0.05f);
            spritePlayer.flipX = false;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * 0.05f);
            spritePlayer.flipX = true;
        }
    }
}
