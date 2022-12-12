using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] private float speed = 1.0f;

    void Update()
    {
          transform.Translate(Vector3.left * Time.deltaTime * speed);

        if (transform.position.x < -15.0f)
            transform.position += new Vector3(30, 0, 0);
    }
}
