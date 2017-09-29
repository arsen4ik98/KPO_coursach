using UnityEngine;
using System.Collections;

public class trigger_key_dor : MonoBehaviour {
    private Animator animator;
    new private Rigidbody2D rigidbody;
    public GameObject door;
	// Use this for initialization
	void Start () {
	
	}
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "button")
        {
            Debug.Log("111");
            door.transform.position = new Vector2(7.7f, -3.88f);
            

        }
    }
}
