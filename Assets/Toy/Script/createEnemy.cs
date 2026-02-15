using System.Collections.Generic;
using UnityEngine;

public class createEnemy : MonoBehaviour
{
    public GameObject enemy;
    public List<Sprite> enemies;
    public int enemyMaxCount = 4;
    public float eSpeed;
    public SpriteRenderer spriteRenderer;
    public meteoriteMovement enemySpawn;

    private float spawnI = 2f;
    private float nextSpawnTime;
    private float eT=15f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] allEnemise = GameObject.FindGameObjectsWithTag("Enemy");

        //if enemies's number <enemyMaxCount ,add them to Max
        if (allEnemise.Length < enemyMaxCount)
        {
            int needToSpawn = enemyMaxCount - allEnemise.Length;
            for (int i = 0; i < needToSpawn; i++)
            {
                spawnEnemies();
            }
        }
    }

    void spawnEnemies()
    {
        //give enemy ship random position
        Vector2 mPosition = enemySpawn.GetRandomPosition();

        //spawn time gap
        nextSpawnTime = nextSpawnTime + 1 * Time.deltaTime;
        if (nextSpawnTime > spawnI)
        {
            GameObject e = Instantiate(enemy, mPosition, Quaternion.identity);

            //different shape of meteorite
            SpriteRenderer spriteRenderer = e.GetComponent<SpriteRenderer>();
            if (spriteRenderer != null && enemies.Count > 0)
            {
                Sprite randomSprite = enemies[Random.Range(0, enemies.Count)];
                spriteRenderer.sprite = randomSprite;
            }

            Destroy(e, eT);
            nextSpawnTime = 0;
        }
    }


}
