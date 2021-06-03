using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonballScript : MonoBehaviour
{
    private Rigidbody rb;
    private CannonControlScript cannon;
    public float airSpeed = 10;
    public float explosionPower = 10;
    public float explosionRadius = 10;

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
        rb.AddRelativeForce(transform.up * power, ForceMode.Impulse);
        // END OF CODE
    }

    // Update is called once per frame
    void Update()
    {
        // ADD CODE HERE
        rb.AddForce(new Vector3(Input.GetAxis("Horizontal") * airSpeed, 0, Input.GetAxis("Vertical") * airSpeed));
        // END OF CODE
    }

    private void OnCollisionEnter(Collision other)
    {
        Explode();
        StartCoroutine(cannon.ReturnCamera());
        Destroy(this.gameObject, 1);
    }

    public void Explode()
    {
        // Get every object (rayhit) that is within range of explosion
        foreach (var rayhit in Physics.SphereCastAll(transform.position, explosionRadius, transform.forward, explosionRadius * 2))
        {
            DestructableBuilding block = rayhit.collider.GetComponent<DestructableBuilding>();
            // ADD CODE HERE
            block.GetRigidbody().AddExplosionForce(explosionPower, this.transform.position, explosionRadius);
            // END OF CODE
        }
    }
}
