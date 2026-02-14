using System.Collections.Generic;
using UnityEngine;

public class meteoriteMovement : MonoBehaviour
{
    public GameObject meteorite;
    public List<Sprite> meteorites;
    public SpriteRenderer spriteRenderer;
    public float speed;

    private float exsitTime = 3f;
    private int meteoriteNum;
    private int maxMeteorite = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mPosition = new Vector2();
        GameObject m = Instantiate(meteorite, mPosition, Quaternion.identity);
        while (meteoriteNum < maxMeteorite)
        {
            meteoriteNum++;
            spriteRenderer = m.GetComponent<SpriteRenderer>();
            if (spriteRenderer != null && meteorites.Count > 0)
            {
                Sprite randomSprite = meteorites[Random.Range(0, meteorites.Count)];
                spriteRenderer.sprite = randomSprite;
            }
            
            speed = Random.Range(0.5f, 3f);
            transform.Translate(transform.right * -speed * Time.deltaTime);
            Destroy(m, exsitTime);
            
        }
        
        
    }

    void RandomPosition()
    {

    }
}
