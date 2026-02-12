using UnityEngine;
using static Movement;

public class bulletMovement : MonoBehaviour
{
    public float speed = 10f;
    public int damage = 1;
    public GameObject bullet;
    public Camera mCamera;

    private bool isEnemyBullet = false;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (isEnemyBullet)
        {
            transform.Translate(transform.right * -speed * Time.deltaTime);
            
        }
        else if(isEnemyBullet == false) 
        {
            transform.Translate(transform.right * speed * Time.deltaTime);
            
        }
        

    }
    public void checkOffCamera(GameObject b)
    {
        Vector3 viewCamera = mCamera.WorldToViewportPoint(transform.position);
        if (viewCamera.x < -0.1f || viewCamera.x > 1.1f || viewCamera.y < -0.1f || viewCamera.y > 1.1f)
        {
            Destroy(b);
            Debug.Log("destory!");
        }
    }

}
