using UnityEngine;

public class AllCollision : MonoBehaviour
{
    public float collisionDistance = 0.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //use tag to find those object
        //FindGameObjectsWithTag("")code was learned in Intergration and pipeline class
        GameObject[] bullets = GameObject.FindGameObjectsWithTag("Bullet");
        GameObject[] meteorites = GameObject.FindGameObjectsWithTag("Meteorite");
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

        //check collision
        // foreach code came from https://learn.unity.com/tutorial/loops-z2b
        foreach (GameObject bullet in bullets)
        {
            foreach (GameObject meteorite in meteorites)
            {
               
                float distance = Vector2.Distance(bullet.transform.position, meteorite.transform.position);
                    
                if (distance < collisionDistance)
                {
                    Destroy(bullet);
                    Destroy(meteorite);
                    return;
                }
                    
                foreach (GameObject enemite in enemies)
                {
                    float distanceOfShip = Vector2.Distance(bullet.transform.position, enemite.transform.position);
                    if(distanceOfShip < collisionDistance)
                    {
                        Destroy(bullet);
                        Destroy(enemite);
                    }
                        
                }

             
            }
        }
    }

    

}
