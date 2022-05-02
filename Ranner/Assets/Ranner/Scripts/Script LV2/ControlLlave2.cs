using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlLlave2 : MonoBehaviour
{
    public bool RecogioLlave2;

    void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.SetActive(false);

        RecogerLlave();
    }

    // Update is called once per frame
    void RecogerLlave()
    {
        RecogioLlave2 = true;
    }
}
