using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn; 

    void Start()
    {
        SpawnObject();
    }

    void SpawnObject()
    {
        if (objectToSpawn != null)
        {
            Instantiate(objectToSpawn, transform.position, Quaternion.identity);
        }
        else
        {
            Debug.LogError("Object is not in the Spawner!");
        }
    }
}