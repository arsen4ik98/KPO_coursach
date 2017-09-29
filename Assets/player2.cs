using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player2 : MonoBehaviour
{

    private float speed = 5.0f;
    private float jump = 25.0f;


   

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.I))
        {
            transform.Translate(new Vector2(0.0f, jump * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.L))
        {
            transform.Translate(new Vector2(speed * Time.deltaTime, 0.0f));
        }
        if (Input.GetKey(KeyCode.J))
        {
            transform.Translate(new Vector2(-speed * Time.deltaTime, 0.0f));
        }
    }

}
