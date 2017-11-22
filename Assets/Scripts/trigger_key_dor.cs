using UnityEngine;
using System.Collections;

public class trigger_key_dor : MonoBehaviour {
    public Animator animator;
    new private Rigidbody2D rigidbody ;
    public GameObject door , key_open, key_close, gras;
    public Transform ClickCheck;

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

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "button")
        {
            animator.SetBool("Click", true);
            door.transform.position = new Vector2(-0.06f, -3.88f);
        }
        //if (col.gameObject.tag != "button")
        //{
        //    animator.SetBool("Click", false);
        //}
    }

   public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "button1")
        {
            gras.transform.localScale = new Vector2(1.6f, 1f);
        }

    }
}
