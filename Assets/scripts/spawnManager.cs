using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{

    [SerializeField]
    private GameObject _asteroidPrefab;
    public bool _isSpawning = true;
    [SerializeField]
    private float _asteroidRespawnTime = 1f;
    // Start is called before the first frame update
    void Start()
    {
            StartCoroutine(spawnAsteroids());

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator spawnAsteroids()
    {
        while(_isSpawning == true)
        {
            Vector3 posToSpawn = new Vector3(Random.Range(-2.21f, 2.21f), 5.26f, 0);
            GameObject newEnemy = Instantiate(_asteroidPrefab, posToSpawn, Quaternion.identity);
            yield return new WaitForSeconds(_asteroidRespawnTime);
        }
    }
}
