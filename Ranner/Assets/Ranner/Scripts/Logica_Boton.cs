using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Logica_Boton : MonoBehaviour
{
    public bool iniciarNivel;
    public int indiceNivel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CambiarNivel (int indice) {
        SceneManager.LoadScene(indice);
    }
}
