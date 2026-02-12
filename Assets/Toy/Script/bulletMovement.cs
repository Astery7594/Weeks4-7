using UnityEngine;
using static Movement;

public class bulletMovement : MonoBehaviour
{
    public float speed = 10f;
    public int damage = 1;
    public GameObject bullet;
    public bool isEnemyBullet = false;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //make bullets MOVE
        if (isEnemyBullet)
        {
            transform.Translate(transform.right * -speed * Time.deltaTime);
            
        }
        else if(isEnemyBullet == false) 
        {
            transform.Translate(transform.right * speed * Time.deltaTime);
            
        }
        
    }

}
