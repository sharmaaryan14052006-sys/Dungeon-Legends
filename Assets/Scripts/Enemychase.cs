using UnityEngine;

public class Enemychase : MonoBehaviour
{
public float moveSpeed = 3f;
public Transform player;
private Rigidbody2D rb;
public bool canMove = true;
void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
void FixedUpdate()
    {if (!canMove) return;
        Vector2 direction = ((Vector2)player.position - rb.position).normalized;
        rb.MovePosition(rb.position + direction * moveSpeed * Time.fixedDeltaTime);
    }
}
