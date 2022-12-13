using UnityEngine;

public class Fireball : MonoBehaviour
{
    public Vector2 StartingVelocity;

    private void Start()
    {
        GetComponent<Rigidbody2D>().velocity = StartingVelocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<Enemy>(out var enemy))
            enemy.Die();
        GameObject.Destroy(gameObject);
    }
}
