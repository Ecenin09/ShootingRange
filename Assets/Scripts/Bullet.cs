using System;
using System.Collections;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject particleObject;
    public float fireForce = 25.0f;
    public float timeFly = 10f;
    public float blustRadius = 1f;
    public float destroyRadius = 0.2f;
    public float explosionForce = 10f;
    void Start()
    {
        // Start Impulse for bullet
        gameObject.GetComponent<Rigidbody>().AddForce(transform.forward*fireForce,ForceMode.Impulse);
        // For clear a game field 
        Destroy(gameObject,timeFly); 
    }

    private void Explosion(Transform explosionPosition)
    {
        Collider[] collidersDestroy = Physics.OverlapSphere(transform.position, destroyRadius);
        foreach (var nearObject in collidersDestroy)
        {
            Destroy(nearObject.gameObject);
        }
        
        Collider[] collidersSplash = Physics.OverlapSphere(transform.position, blustRadius);
        foreach (var nearObject in collidersSplash)
        {
            Rigidbody rbNearObject = nearObject.gameObject.GetComponent<Rigidbody>();
            if (rbNearObject != null)
            {
                Debug.Log(rbNearObject);
                rbNearObject.isKinematic = false;
                rbNearObject.AddExplosionForce(explosionForce, explosionPosition.position, blustRadius);
            }
        }
        Destroy(gameObject);
    }
    private void OnCollisionEnter(Collision other)
    {
        Explosion(gameObject.transform);
    }
}
