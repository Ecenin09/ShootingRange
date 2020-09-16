
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    
    private float _tiltAngle = 45.0f;
    private Vector3 _direction;
    
    public int startAmountOfTarget = 20;
    public FixedJoystick joystick;
    public GameObject[] bulletPrefabArray;
    public Transform firePlace;
    private void Start()
    {
        // Spawn start amount target
        var startSpawner =  FindObjectOfType<LevelGenerator>();
        for (int i = 0; i < startAmountOfTarget; i++)
        {
            startSpawner.SpawnTarget();
        }
        // get the joystick
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

    // Method for create a bullet in fireplace 
    public void Fire()
    {
        GameObject bullet = bulletPrefabArray[Random.Range(0, bulletPrefabArray.Length)];
        Instantiate(bullet, firePlace.position, transform.rotation);
        
    }

}
