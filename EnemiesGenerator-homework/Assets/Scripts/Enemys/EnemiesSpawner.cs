using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesSpawner : MonoBehaviour
{
    [SerializeField] private List<Enemy> _enemyPrefabs = new List<Enemy>();
    [SerializeField] private List<Target> _targets = new List<Target>();
    [SerializeField] private List<Transform> _pointsSpawn = new List<Transform>();
    [SerializeField] private float _smoothIncreaseDuration = 2f;

    private void Start()
    {
        StartCoroutine(CreateEnemies());
    }

    private int RandomPoint() => Random.Range(0, _pointsSpawn.Count);

    private Enemy RandomEnemy() => _enemyPrefabs[Random.Range(0, _enemyPrefabs.Count)];

    private Target RandomTarget() => _targets[Random.Range(0, _targets.Count)];

    private IEnumerator CreateEnemies()
    {  
        var duration = new WaitForSeconds(_smoothIncreaseDuration);

        while (true)
        {
            Vector3 position = _pointsSpawn[RandomPoint()].position;
            Transform target = RandomTarget().transform;

            Enemy newEnemy = Instantiate(RandomEnemy(), position, Quaternion.identity);
            newEnemy.Init(target);

            yield return duration;
        }        
    }
}
