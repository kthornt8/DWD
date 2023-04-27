using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaisyScript : MonoBehaviour
{
    public Rigidbody myRigidbody;
    public float jumpStrength;
    
    // Start is called before the first frame update
    void Start()
    {
        
        gameObject.name = "Daisy";
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
    public void daisyPJump()
    {
        
            myRigidbody.velocity = Vector2.up * jumpStrength;
            Debug.Log("works");
        
    }
}
