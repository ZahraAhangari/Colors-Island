using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private float Move;
    public float jump;
    public bool isJumping;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(speed * Move, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && isJumping == false){
            rb.AddForce(new Vector2(rb.velocity.x, jump));
            Debug.Log("jump");
        }

    }

    private void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.tag == "Ground"){
            isJumping = false;
            Debug.Log("on the Ground");
        }
    }

    private void OnCollisionExit2D(Collision2D other){
        if(other.gameObject.tag == "Ground"){
            isJumping = true;
            Debug.Log("on the fly");
        }
    }
}
