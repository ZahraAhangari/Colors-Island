using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{

    public string nextLevelName;
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
            Invoke("LoadNextScene", Delay);
        }
    }
    void LoadNextScene()
    {
        SceneManager.LoadScene(nextLevelName);
        Debug.Log("Loading is ok");
    }
}
