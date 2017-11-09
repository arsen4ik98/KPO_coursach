using UnityEngine;
using System.Collections;

public class trigger_key_dor : MonoBehaviour {
    private Animator animator1;
    new private Rigidbody2D rigidbody;
    public GameObject door , key_open, key_close, gras;

	// Use this for initialization
	void Start () {
       
	
	}
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator1 = GetComponent<Animator>();
    }
	// Update is called once per frame
	void Update () {
	    
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "button")
        {
            Debug.Log("111");
            //door.transform.position = new Vector2(-0.06f, -3.88f);
            Destroy(key_open);
            animator1.Play("open");
            Debug.Log("animation");
        }
        if (col.gameObject.tag == "button1")
        {
            gras.transform.localScale = new Vector2(1.6f, 1f);
           // door.PlayAnimation(animation.Play("New Animation"));
           // AnimationState time = animator(hgv);
        }

    }
}
