using UnityEngine;

public class ActivationBox : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            TreeOpacityController[] trees = FindObjectsOfType<TreeOpacityController>();
            foreach (TreeOpacityController tree in trees)
            {
                tree.SetOpaque();
            }

            Destroy(gameObject);
        }
    }
}
