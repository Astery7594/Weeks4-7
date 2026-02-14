using System.Collections.Generic;
using UnityEngine;

public class createEnemy : MonoBehaviour
{
    public GameObject enemy;
    public List<Sprite> enemies;
    public int enemyMaxCount = 4;
    public float eSpeed;
    public SpriteRenderer spriteRenderer;
    public meteoriteMovement enemyShip;

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
        enemyShip.s = nextSpawnTime;
        enemyShip.sI = spawnI;
        enemyShip.spawnMeteorite();
    }




}
