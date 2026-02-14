using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class meteoriteMovement : MonoBehaviour
{
    //Acturly it's spawner not movement :D
    //meteoriteMovement is in bulletMovement script
    public GameObject meteorite;
    public List<Sprite> meteoritesOutlook;
    public SpriteRenderer spriteRenderer;
    public float mSpeed;

    private float exsitTime = 10f;
    private int maxMeteorite = 3;
    public float sI = 2f;
    public float s;
    private Camera mCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        CheckAndSpawn();
        
    }

    public void spawnMeteorite()
    {
        //give meteorite random position
        Vector2 mPosition= GetRandomPosition();

        //spawn time gap
        s = s+1*Time.deltaTime;
        if (s > sI)
        {
            GameObject m = Instantiate(meteorite, mPosition, Quaternion.identity);

            //different shape of meteorite
            SpriteRenderer spriteRenderer = m.GetComponent<SpriteRenderer>();
            if (spriteRenderer != null && meteoritesOutlook.Count > 0)
            {
                Sprite randomSprite = meteoritesOutlook[Random.Range(0, meteoritesOutlook.Count)];
                spriteRenderer.sprite = randomSprite;
            }

            Destroy(m, exsitTime);
            s = 0;
        }
    }

    void CheckAndSpawn()
    {
        GameObject[] allMeteorites = GameObject.FindGameObjectsWithTag("Meteorite");

        //if meteorites's number <3,add them to 3
        if (allMeteorites.Length < maxMeteorite)
        {
            int needToSpawn = maxMeteorite - allMeteorites.Length;
            for (int i = 0; i < needToSpawn; i++)
            {
                spawnMeteorite();
            }
        }
    }
    public Vector2 GetRandomPosition()
    {
        Vector2 STR = mCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height));
        Vector2 SBR = mCamera.ScreenToWorldPoint(Vector3.zero);
        float spawnX = STR.x + 1f;
        float minY = SBR.y + 0.5f;
        float maxY = STR.y - 0.5f;
        float randomY = Random.Range(minY, maxY);
        Vector2 mPosition = new Vector2(spawnX, randomY);
        return mPosition;
    }

}
