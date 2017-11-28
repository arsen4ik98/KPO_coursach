using UnityEngine;
using System.Collections;

public class trigger_key_dor : MonoBehaviour {
    public Animator animator;
    new private Rigidbody2D rigidbody ;
    public GameObject door , key_open, key_close, gras;
    private bool isClick = false;
    public Transform ClickCheck;
    private float ClickRadius = 0.4f;
    public LayerMask whatIsClick;

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
        if (col.gameObject.tag == "button" )
        {
            animator.SetBool("Click", true);
            
        }

    }
    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "button")
        {
           animator.SetBool("Click", false);
        }
    }

   public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "button1")
        {
            gras.transform.localScale = new Vector2(0.4126858f, 1f);
            gras.transform.position = new Vector2(-10.4f, 0.35f);
        }
   }

   public void FixedUpdate()
   {
       isClick = Physics2D.OverlapCircle(ClickCheck.position, ClickRadius, whatIsClick);
       //устанавливаем соответствующую переменную в аниматоре
       animator.SetBool("Click1", isClick);
   }
}
