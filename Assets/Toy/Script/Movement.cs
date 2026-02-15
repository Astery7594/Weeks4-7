using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public float speed = 5;
    public GameObject bullet;
    public Transform firePoint;
    public float fireRate = 0.2f;

    private float nextFireTime = 0f;
    private float liveTime = 3f;
    private GameObject bullets;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        MoveSpaceShip();
        //Use space to create bullets
        if (Keyboard.current.spaceKey.isPressed && Time.time >= nextFireTime)
        {
            //Create bullets in a logical frequence (that can change)
            bullets = Instantiate(bullet, firePoint.position, Quaternion.identity);
            nextFireTime = Time.time + fireRate;
        }
        

        //Destory bullets that missed enemy and disapered off screen though time
        Destroy(bullets, liveTime);

    }
    void MoveSpaceShip()
    {
        //Four direction movement
        if (Keyboard.current.wKey.isPressed)
        {
            Vector2 p = transform.position;
            p.y += speed * Time.deltaTime;
            transform.position = p;
        }
        if (Keyboard.current.sKey.isPressed)
        {
            Vector2 p = transform.position;
            p.y -= speed * Time.deltaTime;
            transform.position = p;
        }
        if (Keyboard.current.aKey.isPressed)
        {
            Vector2 p = transform.position;
            p.x -= speed * Time.deltaTime;
            transform.position = p;
        }
        if (Keyboard.current.dKey.isPressed)
        {
            Vector2 p = transform.position;
            p.x += speed * Time.deltaTime;
            transform.position = p;
        }
    }

}
