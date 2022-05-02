using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov_camara : MonoBehaviour
{

    public Transform playerTransform;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3 (playerTransform.position.x + 6, 6.42f, -10);
        //transform.position = new Vector3 (playerTransform.position.y + 6, 6.42f, -10);
        transform.position = new Vector3 (playerTransform.position.x + offset.x, playerTransform.position.y + offset.y, offset.z);
       
    }
}

