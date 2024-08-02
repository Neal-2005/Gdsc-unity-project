using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovvement : MonoBehaviour
{

    //Player player;
    [SerializeField]

    

    private Transform localTrans;

    private Vector3 mousePos;

    private Vector3 lastMousePos;

    private Vector3 newPosForTrans;

    private Touch touch;
    [SerializeField]
    private float _touchSpeed = 0.002f;
    [SerializeField]
    private GameObject _gameOverPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        touchMovement();
    }

    void  touchMovement()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(
                    transform.position.x + touch.deltaPosition.x * _touchSpeed,
                    transform.position.y + touch.deltaPosition.y * _touchSpeed,
                    transform.position.z);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "asteroid")
        {
            _gameOverPanel.SetActive(true);
            Destroy(this.gameObject);
            

        }
    }
}
