using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class asteroid : MonoBehaviour
{

    [SerializeField]
    private float _asteroidSpeed = 1f;
    [SerializeField]
    private GameObject _gameOverPanel;

    private spawnManager _spawnManager;
    // Start is called before the first frame update
    void Start()
    {
        _spawnManager = GameObject.Find("spawnManager").GetComponent<spawnManager>();
    }

    // Update is called once per frame
    void Update()
    {
        asteroidMovement();
    }

    void asteroidMovement()
    {
        
        transform.Translate(Vector3.down * _asteroidSpeed * Time.deltaTime);


        if (transform.position.y < -5.22f)
        {
            float randomX = Random.Range(-2.21f, 2.21f);
            transform.position = new Vector3(randomX, 5.26f, 0);
        }
    }

   


    public void retryButton()
    {
        SceneManager.LoadScene(1);
    }
}
