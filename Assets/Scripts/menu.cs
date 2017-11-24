using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class menu : MonoBehaviour
{

    bool mous;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
     

    }

    void OnMouseDown()
    {
       Application.LoadLevel("1_level");
        Debug.Log("21412");
    }
}
