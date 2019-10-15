using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fantasmaFrente : MonoBehaviour
{

    private bool colide = false;
    private float move = -2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
        GetComponent<SpriteRenderer>().flipY = !GetComponent<SpriteRenderer>().flipY;
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
