using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;

    private SpriteRenderer spriteRenderer;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 br = Camera.main.ScreenToWorldPoint(Vector2.zero);
        
    }
}
