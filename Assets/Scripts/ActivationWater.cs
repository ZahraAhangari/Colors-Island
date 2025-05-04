using UnityEngine;

public class ActivationWater : MonoBehaviour
{
    
    public GameObject objectToShow; 

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            gameObject.SetActive(false);

            if (objectToShow != null)
            {
                objectToShow.SetActive(true);
            }
        }
    }
}

