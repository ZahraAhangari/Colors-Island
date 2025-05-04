using UnityEngine;

public class ActivationWater : MonoBehaviour
{
    
    public GameObject objectToShow; 
    public AudioClip winSound; 
    private AudioSource audioSource;
    public float Delay = 1f; 


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {       
        if(other.gameObject.tag == "Player")
        {
            audioSource.PlayOneShot(winSound);
            Invoke("Disable", Delay);
        }
    }

    void Disable()
    {
        gameObject.SetActive(false);
        objectToShow.SetActive(true);
    }
    
}

