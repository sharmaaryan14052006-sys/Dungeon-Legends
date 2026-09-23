using UnityEngine;

public class Doorexit : MonoBehaviour
{
public Enemychase enemy;
public GameObject winText;
void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerInventory inventory = other.GetComponent<PlayerInventory>();
            if (inventory.hasKey)
            {   enemy.canMove = false;
                winText.SetActive(true);
            }
        }
    }
}
