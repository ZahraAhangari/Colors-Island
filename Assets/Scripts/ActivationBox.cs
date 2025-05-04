using UnityEngine;

public class ActivationBox : MonoBehaviour
{
    public AudioClip winSound; 
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            OpacityController[] itemsOpacity = FindObjectsOfType<OpacityController>();
            foreach (OpacityController item in itemsOpacity)
            {
                item.SetOpaque();
            }

            audioSource.PlayOneShot(winSound);
            Destroy(gameObject, winSound.length);
        }
    }
}
