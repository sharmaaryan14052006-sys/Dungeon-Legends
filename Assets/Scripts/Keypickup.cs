using UnityEngine;

public class Keypickup : MonoBehaviour
{
void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerInventory>().hasKey = true;
            Destroy(gameObject);
        }
    }  
}
