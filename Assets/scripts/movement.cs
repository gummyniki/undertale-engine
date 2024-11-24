using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // variables
    public Rigidbody2D rb;
    public float speed;
    public Animator animator;

    private string playingAnim;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // movement
        float speedX = Input.GetAxisRaw("Horizontal");
        float speedY = Input.GetAxisRaw("Vertical");


        rb.velocity = new Vector2(speedX, speedY) * speed * Time.deltaTime;



        // animations

        if (Input.GetKey(KeyCode.UpArrow)) {
            
            playingAnim = "walkUp";
            animator.Play(playingAnim);
            
            


        }
        if (Input.GetKey(KeyCode.DownArrow)) {

            playingAnim = "walkDown";
            animator.Play(playingAnim);


        }
        if (Input.GetKey(KeyCode.LeftArrow)) {

            playingAnim = "walkLeft";
            animator.Play(playingAnim);


        }
        if (Input.GetKey(KeyCode.RightArrow)) {

            playingAnim = "walkRight";
            animator.Play(playingAnim);


        }

    }
}