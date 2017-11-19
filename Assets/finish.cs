using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class finish : MonoBehaviour {
    public Text text;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		
	}
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player1" || col.gameObject.tag == "Player2")
        {
            Debug.Log("finish");
            text.text = "Финиш";

        }

    }
}
