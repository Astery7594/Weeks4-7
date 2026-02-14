using System.Collections.Generic;
using UnityEngine;

public class createEnemy : MonoBehaviour
{
    public GameObject enemy;
    public List<Sprite> enemies;
    public int enemyMaxCount = 4;
    public float eSpeed;
    public SpriteRenderer spriteRenderer;

    private float spawnI = 1f;
    private int currentEnemyCount = 0;
    private float nextSpawnTime;
    private Camera mCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        //Create enemy in different position
        Vector2 enemySpawnPlace = new Vector2();

        //create enemy ship and change their outlook
        GameObject newEnemy = Instantiate(enemy,enemySpawnPlace, Quaternion.identity);
        spriteRenderer = newEnemy.GetComponent<SpriteRenderer>();
        if (spriteRenderer != null && enemies.Count>0)
        {
            Sprite randomSprite = enemies[Random.Range(0, enemies.Count)];
            spriteRenderer.sprite = randomSprite;
        }

    }


}
