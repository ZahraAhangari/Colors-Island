using UnityEngine;

public class DeathScript : MonoBehaviour
{
    public AudioClip loseSound; 
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            audioSource.PlayOneShot(loseSound);

            GameObject startPoint = GameObject.FindGameObjectWithTag("startPoint");
            other.transform.position = startPoint.transform.position;
            
        }
    }
}