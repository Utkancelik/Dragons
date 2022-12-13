using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            var projectile = Instantiate(projectilePrefab,
                transform.position, 
                projectilePrefab.transform.rotation);
        }
    }
}
