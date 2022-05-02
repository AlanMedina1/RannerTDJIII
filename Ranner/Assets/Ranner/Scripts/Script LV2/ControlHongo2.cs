using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlHongo2 : MonoBehaviour
{
    public ControlLlave2 CL;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (CL.RecogioLlave2)
        {
            PasarNivel();
        } else{
            TeOlvidasteLlave();
        }
        
    }

    void PasarNivel()
    {
        SceneManager.LoadScene("TransiciónLevel2");
    }

    void TeOlvidasteLlave() 
    {
        SceneManager.LoadScene("GameOver");
    }
}
