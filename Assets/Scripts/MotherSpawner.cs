using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotherSpawner : MonoBehaviour
{
    [SerializeField] private Spawner[] _enemyHomeDoors;
    
    private WaitForSeconds _waitTwoSeconds = new WaitForSeconds(2f);
    private System.Random _random = new System.Random();
    private Coroutine _coroutine;

    private void Start()
    {
        StartCoroutine(SpawnEnemys(_enemyHomeDoors[(_random.Next(0, _enemyHomeDoors.Length))]));
    }

    private IEnumerator SpawnEnemys(Spawner spawner)
    {
        while (true)
        {
            spawner = _enemyHomeDoors[_random.Next(0, _enemyHomeDoors.Length)];

            spawner.Spawn();

            yield return _waitTwoSeconds;
        }
    }
}

