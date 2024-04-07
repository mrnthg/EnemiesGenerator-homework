using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speedMovement;

    private Vector3 _direction;

    public void Init(Vector3 direction)
    {
        _direction = direction;
    }

    private void Update()
    {
        Mover();
    }

    private void Mover()
    {
        transform.Translate(_direction * (_speedMovement * Time.deltaTime));
    }
}
