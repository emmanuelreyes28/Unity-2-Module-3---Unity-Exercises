using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public Rigidbody rb;
    public int damage = 10;

    private void Start() 
    {
        rb = GetComponent<Rigidbody>();   
    }

    public void FireBullet(Vector3 direction, float power)
    {
        rb.AddForce(direction * power, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision other) 
    {
        HealthScript hs = other.gameObject.GetComponent<HealthScript>();
        if(hs != null)
        {
            hs.ChangeHealth(-1*damage);
        }
        Destroy(this.gameObject);
    }
}
