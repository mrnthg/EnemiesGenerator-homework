using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private List<GameObject> _pointSpawn = new List<GameObject>();
    [SerializeField] private float _smoothIncreaseDuration = 2f;

    private void Start()
    {
        StartCoroutine(CreateEnemies());
    }

    private int RandomPoint()
    {
        int numberPoint = Random.Range(0, _pointSpawn.Count);
        return numberPoint;
    }

    private int RandomRotate()
    {
        int numberPoint = Random.Range(0, 361);
        return numberPoint;
    }

    private IEnumerator CreateEnemies()
    {
        float elapsedTime = 0f;

        while (elapsedTime < _smoothIncreaseDuration)
        {
            elapsedTime += Time.deltaTime;
            _enemyPrefab.transform.position = _pointSpawn[RandomPoint()].transform.position;
            _enemyPrefab.transform.rotation = Quaternion.Euler(0, RandomRotate(), 0);
            Instantiate(_enemyPrefab);

            yield return new WaitForSeconds(_smoothIncreaseDuration);
        }
        
    }
}
