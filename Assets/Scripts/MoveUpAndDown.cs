using UnityEngine;

public class MoveUpAndDown : MonoBehaviour
{
    [SerializeField] private float HeightVariance = 1f;

    private void Update()
    {
        transform.position += Vector3.up * Mathf.Sin(Time.time) * Time.deltaTime * HeightVariance;
    }
}
