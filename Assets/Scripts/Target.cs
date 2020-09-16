using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private LevelGenerator _generator;
    private Rigidbody[] _rbChildren;
    public float timeDestroy = 15f;
    private void Start()
    {
        
        _generator = FindObjectOfType<LevelGenerator>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Bullet>() != null)
        {
            
            
 //           _rbChildren = gameObject.GetComponentsInChildren<Rigidbody>();
 //           foreach (var child in _rbChildren)
 //           {
 //               child.isKinematic = false;
 //           }
            Destroy(gameObject.GetComponent<Collider>());
            _generator.SpawnTarget();
            Destroy(gameObject,timeDestroy);
        }
    }

}
