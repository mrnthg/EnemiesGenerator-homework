using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesSpawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private List<GameObject> _pointSpawn = new List<GameObject>();
    [SerializeField] private float _smoothIncreaseDuration = 2f;

    private float _minPosition = -1;
    private float _maxPosition = 1;

    private void Start()
    {
        StartCoroutine(CreateEnemies());
    }

    private int RandomPoint() => Random.Range(0, _pointSpawn.Count);

    private Vector3 RandomDirection() => new Vector3(Random.Range(_minPosition, _maxPosition), 0, Random.Range(_minPosition, _maxPosition)).normalized;

    private IEnumerator CreateEnemies()
    {  
        var duration = new WaitForSeconds(_smoothIncreaseDuration);

        while (true)
        {
            Vector3 position = _pointSpawn[RandomPoint()].transform.position;   

            Enemy newEnemy = Instantiate(_enemyPrefab, position, Quaternion.identity);
            newEnemy.Init(RandomDirection());

            yield return duration;
        }
        
    }
}
