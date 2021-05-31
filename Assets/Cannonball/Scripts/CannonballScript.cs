using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonballScript : MonoBehaviour
{
    private Rigidbody rb;
    private CannonControlScript cannon;

    private void Awake() 
    {
        rb = GetComponent<Rigidbody>();
        // ADD CODE HERE
        
        // END OF CODE    
    }

    public void Launch(CannonControlScript cannon, float power, float angle)
    {
        this.cannon = cannon;

        // ADD CODE HERE
        
        // END OF CODE
    }

    // Update is called once per frame
    void Update()
    {
        // ADD CODE HERE
        
        // END OF CODE
    }

    private void OnCollisionEnter(Collision other) 
    {

        StartCoroutine(cannon.ReturnCamera());
        Destroy(this.gameObject, 2);
    }
}
