using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speedMovement;

    private Transform _target;

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
    }
}
