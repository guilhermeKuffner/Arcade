using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{

    public float speed;
    GameObject player;
    public Animator anim;
    public Rigidbody2D RB;
    public Collider2D col;
    Vector2 moveInput;
    bool isAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        player= GameObject.FindGameObjectWithTag("Player");
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Animations();
        if(player != null && isAlive == true)
        {
            transform.position = Vector2.MoveTowards(transform.position,player.transform.position,speed*Time.deltaTime);
        }

    }
   void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Bullet"))
        {
            isAlive =false;
            anim.SetBool("dead",true);
            Destroy(RB,0.0f);
            Destroy(col,0.0f);
            
            Destroy(gameObject,0.9f);
        }

    }
    void Animations()
    {
        float x = player.transform.position.x - transform.position.x;
        float y = player.transform.position.y - transform.position.y;
        float z = (x*x)-(y*y);
    
        if (x > 0 && z>0)
        { 
          
             anim.SetBool("right",true);
            
             anim.SetBool("left", false);
             anim.SetBool("up", false);
             anim.SetBool("down", false);
            

        }
        if (x < 0 && z>0)
        {
       
             anim.SetBool("left", true);
             anim.SetBool("right", false);
            
             anim.SetBool("up", false);
             anim.SetBool("down", false);
            
        }
      if (y > 0 && z<0)
        {
      
             anim.SetBool("up", true);
             anim.SetBool("right", false);
             anim.SetBool("left", false);
            
             anim.SetBool("down", false);
        }
        if (y < 0 && z<0)
        {
         
             anim.SetBool("down", true);
             anim.SetBool("right", false);
             anim.SetBool("left", false);
             anim.SetBool("up", false);
            
          
        }
    }
        
}
