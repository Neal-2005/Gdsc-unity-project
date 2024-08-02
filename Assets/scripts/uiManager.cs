using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uiManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void playLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void retryLevel()
    {
        SceneManager.LoadScene(1);
    }
}
