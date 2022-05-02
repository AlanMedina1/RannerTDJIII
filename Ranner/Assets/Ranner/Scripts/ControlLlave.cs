using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlLlave : MonoBehaviour
{
    public bool RecogioLlave;

    void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.SetActive(false);

        RecogerLlave();
    }

    // Update is called once per frame
    void RecogerLlave()
    {
        RecogioLlave = true;
    }
}
