using UnityEngine;
using UnityEngine.Events;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Point _point;
    [SerializeField] private Enemy _enemy;
    
    public void Spawn()
    {
        _enemy.AssignPoint(_point);
        Instantiate(_enemy, transform.position, Quaternion.identity);
    }
}
