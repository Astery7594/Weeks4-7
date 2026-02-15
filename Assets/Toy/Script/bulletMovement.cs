using UnityEngine;
using static Movement;

public class bulletMovement : MonoBehaviour
{
    public float speed = 10f;
    public int damage = 1;
    public GameObject bullet;
    public bool isEnemyBullet = false;
    public bool isMeteorite;
    public float mSpeed;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   //mSpeed is for the meteorite
        mSpeed = Random.Range(0.5f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        //make bullets MOVE
        if (isEnemyBullet)
        {
            transform.Translate(transform.right * -speed * Time.deltaTime);
            
        }
        else if (isMeteorite)
        {
            transform.Translate(transform.right * -mSpeed * Time.deltaTime);
        }
        else
        {
            //normal player's bullet
            transform.Translate(transform.right * speed * Time.deltaTime);
        }

    }

}
