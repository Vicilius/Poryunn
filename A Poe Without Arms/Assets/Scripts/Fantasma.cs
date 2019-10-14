using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fantasma : MonoBehaviour
{

    private bool colide = false;
    private float move = -2;

    void Start()
    {
        
    }

    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(move, GetComponent<Rigidbody2D>().velocity.y);
        if (colide)
        {
            Flip();
        }
    }

    private void Flip()
    {
        move *= -1;
        GetComponent<SpriteRenderer>().flipX = !GetComponent<SpriteRenderer>().flipX;
        colide = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        bool tagMundo = collision.gameObject.CompareTag("mundo");
        bool tagBlocoTrancado = collision.gameObject.CompareTag("bloco-trancado");
        bool tagFantasma = collision.gameObject.CompareTag("fantasma");
        if (tagMundo || tagBlocoTrancado || tagFantasma)
        {
            colide = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("mundo"))
        {
            colide = false;
        }
    }


}
