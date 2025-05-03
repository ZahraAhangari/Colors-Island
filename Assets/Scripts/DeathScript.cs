using UnityEngine;

public class DeathScript : MonoBehaviour
{
    private GameObject startPoint;
    private GameObject Player;

    void Start()
    {
    Player = GameObject.FindGameObjectWithTag("Player");
    startPoint = GameObject.FindGameObjectWithTag("startPoint");
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
          if (other.gameObject.CompareTag("Player"))
        {
            if (Player != null && startPoint != null)
            {
                Player.transform.position = startPoint.transform.position;
            }
        }
    }
}
