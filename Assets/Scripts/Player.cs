using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Range(1,100)] public float speed;
    public FixedJoystick joystick;
    private Vector3 _direction;
    private void Start()
    {
        if (joystick == null)
        {
            joystick = FindObjectOfType<FixedJoystick>();
        }

    }

    private void Update()
    {
        _direction = joystick.Direction*(Time.deltaTime*speed);
        transform.RotateAround(transform.position,transform.up,_direction.x);
        transform.RotateAround(transform.position,transform.right,-_direction.y);
    }
    

}
