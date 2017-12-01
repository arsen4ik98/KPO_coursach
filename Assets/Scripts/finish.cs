using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class finish : MonoBehaviour {
    public Text text;
    public GameObject player1, player2;
	// Use this for initialization
	void Start () {
        Text text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {

		
	}
    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player1")
        {
            if (col.gameObject.tag == "Player2")
            {
                Debug.Log("finish");
                text.text = "Финишdrrgrgr";
            }
        }
    }
}
