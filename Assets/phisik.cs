using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class phisik : MonoBehaviour
{

    public float speed = 5.0f;
    private float jump = 25.0f;
    new private Rigidbody2D rigidbody;
    private Animator animator;
    public GameObject door;
    private bool isFacingRight = true;


    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
       
        float move = Input.GetAxis("Horizontal");

        
        animator.SetFloat("Speed", Mathf.Abs(move));

       
        rigidbody.velocity = new Vector2(move * speed, rigidbody.velocity.y);

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector2(0.0f, jump * Time.deltaTime));
        }

        if (move > 0 && !isFacingRight)
           
            Flip();
       
        else if (move < 0 && isFacingRight)
            Flip();
    }

    private void Flip()
    {
        //меняем направление движения персонажа
        isFacingRight = !isFacingRight;
        //получаем размеры персонажа
        Vector3 theScale = transform.localScale;
        //зеркально отражаем персонажа по оси Х
        theScale.x *= -1;
        //задаем новый размер персонажа, равный старому, но зеркально отраженный
        transform.localScale = theScale;
    }
   
}
