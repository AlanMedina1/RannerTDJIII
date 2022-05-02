using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlHongo : MonoBehaviour
{
     public ControlLlave CL;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (CL.RecogioLlave)
        {
            PasarNivel();
        } else{
            TeOlvidasteLlave();
        }
        
    }

    void PasarNivel()
    {
        SceneManager.LoadScene("TransiciónLevel1");
    }

    void TeOlvidasteLlave() 
    {
        SceneManager.LoadScene("GameOver");
    }
}
