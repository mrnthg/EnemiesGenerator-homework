using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesSpawner : MonoBehaviour
{
    [SerializeField] private List<Enemy> _enemyPrefabs = new List<Enemy>();
    [SerializeField] private List<Target> _targets = new List<Target>();
    [SerializeField] private List<GameObject> _pointsSpawn = new List<GameObject>();
    [SerializeField] private float _smoothIncreaseDuration = 2f;

    //private float _minPosition = -1; (код из 1го задания)
    //private float _maxPosition = 1; (код из 1го задания)

    private void Start()
    {
        StartCoroutine(CreateEnemies());
    }

    private int RandomPoint() => Random.Range(0, _pointsSpawn.Count);

    //private Vector3 RandomDirection() => new Vector3(Random.Range(_minPosition, _maxPosition), 0, Random.Range(_minPosition, _maxPosition)).normalized; (код из 1го задания)

    private Enemy RandomEnemy() => _enemyPrefabs[Random.Range(0, _enemyPrefabs.Count)];

    private Target RandomTarget() => _targets[Random.Range(0, _targets.Count)];

    private IEnumerator CreateEnemies()
    {  
        var duration = new WaitForSeconds(_smoothIncreaseDuration);

        while (true)
        {
            Vector3 position = _pointsSpawn[RandomPoint()].transform.position;
            Transform target = RandomTarget().transform;

            Enemy newEnemy = Instantiate(RandomEnemy(), position, Quaternion.identity);
            newEnemy.Init(target);

            yield return duration;
        }
        
    }
}
