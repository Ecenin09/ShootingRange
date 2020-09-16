using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class LevelGenerator : MonoBehaviour
{
    public GameObject[] targetPrefab;
    public float distance;
    private Transform _playerPosition;

    private void Start()
    {
        _playerPosition = FindObjectOfType<Player>().transform;
    }

    public void SpawnTarget()
    {
        GameObject target = targetPrefab[Random.Range(0, targetPrefab.Length)];
        Instantiate(target, Random.onUnitSphere * distance,Quaternion.identity);
    }
        
}
