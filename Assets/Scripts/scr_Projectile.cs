using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_Projectile : MonoBehaviour
{
    Rigidbody rigidbody;
    public bool pEnteredTrigger;

    void Awake ()
    {
        rigidbody = GetComponent<Rigidbody>();
        pEnteredTrigger = false;
    }
    void Update()
    {
        if (transform.position.magnitude > 1000.0f)
        {
            Destroy(gameObject);
        }
    }
    public void Launch (Vector3 direction, float force)
    {
        rigidbody.AddForce(Vector3.forward * force);
    }
}
