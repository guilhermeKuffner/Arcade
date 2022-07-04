using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUNS : MonoBehaviour
{
    

    SpriteRenderer sprite;
    public GameObject bullet;
    [SerializeField] private Transform SpawnB;
     private Animator AnimG;

    // Start is called before the first frame update
    void Start()
    {
        AnimG= GetComponent<Animator>();
       
    
        
    }

    // Update is called once per frame
    void Update()
    {
        Mirar();
        Fire();

        
     
        
    }
    void Fire()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            AnimG.SetTrigger("fire");
            Instantiate(bullet,SpawnB.position,transform.rotation);
        }

    }
    private void Mirar()
    {
       /* //rotação
        var screenPoint = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        var angle = Mathf.Atan2(screenPoint.y,screenPoint.x)*Mathf.Rad2Deg;
        transform.eulerAngles = new Vector3(0,0,angle);

        //posição      
        Vector3 PlayerToMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition)-player.position;
        PlayerToMouse.z=0;
        transform.position = player.position + (eixo*PlayerToMouse.normalized);

        //flip
        Vector3 localScale = Vector3.one;
        localScale.x=0.4f;
        
        if(angle>90|| angle<-90)
        {
            
            localScale.y = -0.4f;
    
            
        }
        else
        {
            
            localScale.y=0.4f;
        }
       
        transform.localScale =  localScale;
        */
      
  
    }
        
}
