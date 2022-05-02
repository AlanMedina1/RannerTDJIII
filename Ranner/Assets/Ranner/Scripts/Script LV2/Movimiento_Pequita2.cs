using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movimiento_Pequita2 : MonoBehaviour
{
   private Animator animator;
    //bool canJump;
    private float Horizontal;
    private Rigidbody2D rb;
    public bool PuedeSaltar;
    //salto touch
    public float jumpForce = 650f;

    void Start()
    {
        rb = GetComponent <Rigidbody2D>();
        animator = GetComponent <Animator>();
    }

    void Update()
    {
        //movimiento personaje
        gameObject.transform.position = new Vector3(gameObject.transform.position.x + 9.0f * Time.deltaTime, gameObject.transform.position.y, gameObject.transform.position.z);
        Horizontal = Input.GetAxisRaw("Horizontal");
       
        //salto personaje
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && PuedeSaltar)
        {   
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Force);
            animator.SetBool("EstaSaltando", true);
            PuedeSaltar = false;
        }
    }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            //Collision Plat
            if(collision.gameObject.tag == "Ground") 
            {
                animator.SetBool("EstaSaltando", false);
                PuedeSaltar = true;
            }

            //Muerte
            if(collision.gameObject.tag == "Veneno") 
            {
                if (collision.gameObject.tag == "Veneno")
                {
                    GameOver();
                }
            }

            void GameOver()
            {
                SceneManager.LoadScene("GameOver2");
            }
        }
}
