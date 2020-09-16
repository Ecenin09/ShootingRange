
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    
    private float _tiltAngle = 60.0f;
    public FixedJoystick joystick;
    private Vector3 _direction;
    public GameObject[] prefabArray;
    public Transform firePlace;
    private void Start()
    {
        if (joystick == null)
        {
            joystick = FindObjectOfType<FixedJoystick>();
        }

    }

    private void Update()
    {
        _direction =joystick.Direction;

        transform.RotateAround(transform.position, Vector3.up*_direction.x, _tiltAngle * Time.deltaTime);
        transform.Rotate(Vector3.left*_direction.y,_tiltAngle*Time.deltaTime);
    }

    public void Fire()
    {
        GameObject bullet = prefabArray[Random.Range(0, prefabArray.Length)];
        Instantiate(bullet, firePlace.position, transform.rotation);
        
    }

}
