using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] private Vector2 jumpForce;
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            GetComponent<Rigidbody2D>().AddForce(jumpForce);
    }
}
