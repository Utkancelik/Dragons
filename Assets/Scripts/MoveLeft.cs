using JetBrains.Annotations;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] private float speed = 1.0f;


    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed, Space.World);

        if (transform.position.x < -15.0f)
        {
            transform.position += new Vector3(30, 0, 0);

            ShowRandomSprite();
        }
            
    }
    private void OnEnable()
    {
        ShowRandomSprite();
    }

    private void ShowRandomSprite()
    {
        int randIdx = Random.Range(0, 4);
        int childCount = transform.childCount;

        for (int i = 0; i < childCount; i++)
        {
            Transform child = transform.GetChild(i);
            child.gameObject.SetActive(randIdx == i);
        }
    }

    
}
