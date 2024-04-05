using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _speedMovement;

    private void Update()
    {
        transform.Translate(Vector3.forward * _speedMovement * Time.deltaTime);
    }
}
