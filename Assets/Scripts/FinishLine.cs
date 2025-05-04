using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{

    public string nextLevelName;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(nextLevelName);
            Debug.Log("Loading is ok");
        }
    }
}
