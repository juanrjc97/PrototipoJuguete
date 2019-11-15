using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float toTheObjectForce = 1000f;

    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(0, 0, -toTheObjectForce * Time.deltaTime);
    }

    // Update is called once per frame
    private void Update()
    {
        
        
            if (transform.position.y < -2f)
            {
            
            Destroy(gameObject);
            }
        

    }


    void FixedUpdate()
    {
        rb.AddForce(0, 0, -toTheObjectForce * Time.deltaTime );

        

    }
}
