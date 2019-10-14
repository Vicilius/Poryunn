using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject Alavanca;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        bool tagAlavanca = collision.gameObject.CompareTag("alavanca");


        if (tagAlavanca)
        {
            Alavanca.SetActive(false);
        }
    }
}
