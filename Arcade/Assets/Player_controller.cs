using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_controller : MonoBehaviour
{
    [SerializeField] float move_speed;
    Vector2 moveInput;
    public Animator animator;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");
        if (moveInput.y == 0||moveInput.x == 0)
        {
            animator.SetBool("right", false);
            animator.SetBool("left", false);
            animator.SetBool("up", false);
            animator.SetBool("down", false);
        }
        if (moveInput.x > 0)
        { 
          
            animator.SetBool("right",true);
            
            animator.SetBool("left", false);
            animator.SetBool("up", false);
            animator.SetBool("down", false);
            

        }
        if (moveInput.x < 0)
        {
       
            animator.SetBool("left", true);
            animator.SetBool("right", false);
            
            animator.SetBool("up", false);
            animator.SetBool("down", false);
            
        }
        if (moveInput.y > 0)
        {
      
            animator.SetBool("up", true);
            animator.SetBool("right", false);
            animator.SetBool("left", false);
            
            animator.SetBool("down", false);
        }
        if (moveInput.y < 0)
        {
         
            animator.SetBool("down", true);
            animator.SetBool("right", false);
            animator.SetBool("left", false);
            animator.SetBool("up", false);
            
          
        }

        transform.Translate(moveInput * Time.deltaTime * move_speed);


    }
}
