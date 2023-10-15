using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UIElements;

public class start : MonoBehaviour
{
    private int _speed =3;
    
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal=Input.GetAxis("Horizontal");
        float vertical=Input.GetAxis("Vertical");
            transform.Translate(new Vector3(horizontal,vertical,0)*_speed*Time.deltaTime);
        if(transform.position.y>=0 ){
            transform.position=new Vector3(transform.position.x,0,0);
        }
        if (transform.position.x>6 || transform.position.x<-6  ){
            Math.Round(1.1, 0);
            transform.position=new Vector3(Math.Round(transform.position.x,0),transform.position.y,0);
        }
            
        
         
        
    }
}
