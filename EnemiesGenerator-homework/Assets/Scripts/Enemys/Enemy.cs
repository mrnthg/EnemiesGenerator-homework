using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speedMovement;

    private Transform _target;

    //private Vector3 _direction; (код из 1го задания)

    //public void Init(Vector3 direction) (код из 1го задания)
    //{
    //    _direction = direction; (код из 1го задания)
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
        //transform.Translate(_direction * (_speedMovement * Time.deltaTime)); (код из 1го задания)
    }
}
