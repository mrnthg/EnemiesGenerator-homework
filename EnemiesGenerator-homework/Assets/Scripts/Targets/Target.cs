using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private Transform[] _wayPoints;
    [SerializeField] private float _speed;

    private int _currentWayPoint = 0;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        if (transform.position == _wayPoints[_currentWayPoint].position)
        {
            _currentWayPoint = (_currentWayPoint + 1) % _wayPoints.Length;
        }

        transform.position = Vector3.MoveTowards(transform.position, _wayPoints[_currentWayPoint].position, _speed * Time.deltaTime);
    }
}

