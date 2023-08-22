using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Point _target;

    private float _speed = 1f;

    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, _target.transform.position, _speed * Time.deltaTime);
    }

    public void AssignPoint(Point target)
    {
        _target = target;
    }
}
