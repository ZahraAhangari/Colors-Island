using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public float moveSpeed;
    public float moveDistance; 
    private Vector3 startPosition;
    private bool movingRight = true;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        startPosition = transform.position; 
        spriteRenderer = GetComponent<SpriteRenderer>(); 

    }

    void Update()
    {
        Vector3 targetPosition = movingRight ? startPosition + Vector3.right * moveDistance : startPosition + Vector3.left * moveDistance;

        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

        if (movingRight)
        {
            spriteRenderer.flipX = true; 
        }
        else
        {
            spriteRenderer.flipX = false; 
        }

        if (Vector3.Distance(transform.position, targetPosition) < 0.001f)
        {
            movingRight = !movingRight;
        }
    }
}


