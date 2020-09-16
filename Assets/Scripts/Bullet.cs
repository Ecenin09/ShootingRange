using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float fireForce = 25.0f;
    void Start()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(transform.forward*fireForce,ForceMode.Impulse);        
    }


}
