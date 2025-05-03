using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void onCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Level3");
        }
    }
}
