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
            TreeOpacityController[] trees = FindObjectsOfType<TreeOpacityController>();
            foreach (TreeOpacityController tree in trees)
            {
                tree.SetOpaque();
            }

            audioSource.PlayOneShot(winSound);
            Destroy(gameObject, winSound.length);
        }
    }
}
