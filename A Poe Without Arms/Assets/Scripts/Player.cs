using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameObject Alavanca;
    public GameObject Orbe;
    
    public int vida = 5;
    public int objetivo = 0;
    public Text textoVida;
    public Text textoObjetivo;

    private bool primeiraAlavancaAtivada = true;
    private bool segundaAlavancaAtivada = true;

    void Start()
    {
        textoVida.text = vida.ToString();
        textoObjetivo.text = objetivo.ToString();
        primeiraAlavancaAtivada = true;
        segundaAlavancaAtivada = true;
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        bool tagPrimeiraAlavanca = collision.gameObject.CompareTag("primeiraAlavanca");
        bool tagSegundaAlavanca = collision.gameObject.CompareTag("segundaAlavanca");
        bool tagOrbe = collision.gameObject.CompareTag("orbe");


        if (tagPrimeiraAlavanca && primeiraAlavancaAtivada)
        {
            objetivo++;
            textoObjetivo.text = objetivo.ToString();
            primeiraAlavancaAtivada = false;
        }

        if (tagSegundaAlavanca && segundaAlavancaAtivada)
        {
            objetivo++;
            textoObjetivo.text = objetivo.ToString();
            segundaAlavancaAtivada = false;
        }

        if (primeiraAlavancaAtivada == false && segundaAlavancaAtivada == false)
        {
            Alavanca.SetActive(false);
        }

        if (tagOrbe)
        {
            Orbe.SetActive(false);
        }

        if (collision.gameObject.CompareTag("fantasma"))
        {
            vida--;
            textoVida.text = vida.ToString();

            if (vida <= 0)
            {
                textoVida.text = "Você morreu!!!";
            }
        }
    }
}
