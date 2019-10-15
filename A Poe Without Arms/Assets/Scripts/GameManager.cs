using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject painelCompleto;

    void Start()
    {
    
    }

    void Update()
    {
        
    }

    public void Pause()
    {
        painelCompleto.SetActive(true);
    }

    public void Continuar()
    {
        painelCompleto.SetActive(false);
    }
}
