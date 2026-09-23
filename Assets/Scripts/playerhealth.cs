using UnityEngine;

public class playerhealth : MonoBehaviour
 
{
public int fullhealth=100;
public int playerhealth1;
public GameObject GameOverText;
void Start()
    {
        playerhealth1 = fullhealth;
    }
void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            playerhealth1 -= 10;
            Debug.Log("Health: " + playerhealth1);
            if (playerhealth1 <= 0)
            {
                GameOverText.SetActive(true);
            }
        }
    }
}
