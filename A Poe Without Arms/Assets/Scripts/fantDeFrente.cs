using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FantasmaFren : MonoBehaviour
{
    private bool colide = false;
    private float move = -2;

    void Start()
    {
        
    }

    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, move);
        if (colide)
        {
            Flip();
        }
    }

    private void Flip()
    {
        move *= -1;
        GetComponent<SpriteRenderer>().flipY = !GetComponent<SpriteRenderer>().flipX;
        colide = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        bool tagMundo = collision.gameObject.CompareTag("mundo");
        bool tagBloco = collision.gameObject.CompareTag("bloco-trancado");
        bool tagFantasma = collision.gameObject.CompareTag("fantasma");

        if (tagMundo || tagFantasma || tagBloco)
        {
            colide = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        bool tagMundo = collision.gameObject.CompareTag("mundo");
        bool tagBloco = collision.gameObject.CompareTag("bloco-trancado");
        bool tagFantasma = collision.gameObject.CompareTag("fantasma");

        if (tagMundo || tagFantasma || tagBloco)
        {
            colide = false;
        }
    }
}
