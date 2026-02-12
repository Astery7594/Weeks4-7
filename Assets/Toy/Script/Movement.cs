using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public float speed = 5;
    public GameObject bullet;
    public Transform firePoint;
    public float fireRate = 0.2f;
    public bulletMovement b;

    private float nextFireTime = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
        if (Keyboard.current.spaceKey.isPressed && Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + fireRate;
            
        }

        
    }
    void Shoot()
    {
        GameObject bullets = Instantiate(bullet, transform.position, Quaternion.identity);
        //b.checkOffCamera(bullets);

    }
    
    }
