using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    bool Key_d,Key_a,Key_w,Key_s;
    //store if a key is pressed

    public float Left_Right,Forward_Backward=200f;
    //float variable to store the x,z for movement; Editable in Unity in the PlayerMovement script;
    
    //Rigidbody it`s a componet for different physics
    public Rigidbody rb;
    
    void Update()
    {
        if(Input.GetKey("d"))
        {
            Key_d=true;
        }else {
             Key_d=false;
        }
        if(Input.GetKey("a"))
        {
            Key_a=true;
        }else{
             Key_a=false;
        }
       
        if(Input.GetKey("w"))
        {
            Key_w=true;
        }else {
            Key_w=false;
        }
        if(Input.GetKey("s")){
            Key_s=true;
        }else{
            Key_s=false;
        }
        
    }
   

    //We use FixedUpdate to mess with physics
    void FixedUpdate()
    {
        if(Key_a){
            rb.AddForce(-Left_Right*Time.deltaTime,0,0);
            //Time.deltaTime so users with different framerates move with the same speed; See reference manual for more;
        }
        if(Key_d){
            rb.AddForce(Left_Right*Time.deltaTime,0,0);
           
        }
        if(Key_w){
            rb.AddForce(0,0,Forward_Backward*Time.deltaTime);
            
        }
        if(Key_s){
            rb.AddForce(0,0,-Forward_Backward*Time.deltaTime);
            
        }
    }
}
