using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speedMovement;

    private Transform _target;

    //private Vector3 _direction; (��� �� 1�� �������)

    //public void Init(Vector3 direction) (��� �� 1�� �������)
    //{
    //    _direction = direction; (��� �� 1�� �������)
    //}

    public void Init(Transform target)
    {
        _target = target;
    }

    private void Update()
    {
        Mover();
    }

    private void Mover()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.position, _speedMovement * Time.deltaTime);
        //transform.Translate(_direction * (_speedMovement * Time.deltaTime)); (��� �� 1�� �������)
    }
}
