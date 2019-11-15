using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float ForwardForce = 2000f;

    public float SidewayForce = 500f;

    public float AnchoMapa = 15f;

    

    
    // Update is called once per frame
    //USE FixedUpdate() para poner las fisicas del jugador 
    void FixedUpdate()
    {
        //añade una fuerza hacia adelante 
        // rb.AddForce(0, 0, ForwardForce * Time.deltaTime);
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(0, 0, ForwardForce * Time.deltaTime,ForceMode.VelocityChange); 
        }

        if (Input.GetKey(KeyCode.RightArrow)) {

            rb.AddForce(SidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey(KeyCode.LeftArrow)){

            rb.AddForce(-SidewayForce * Time.deltaTime,0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y<-1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstaculo") {

            ForwardForce = 0;
            SidewayForce = 0;

            FindObjectOfType<GameManager>().EndGame();
            //Debug.Log(collisionInfo.collider.name);

        }
       
    }
}
