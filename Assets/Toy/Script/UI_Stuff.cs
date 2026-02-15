using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.Rendering.DebugUI;

public class UI_Stuff : MonoBehaviour
{
    public GameObject ship;
    public Renderer rShip;
    public Slider Slider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //get renderer
        rShip=ship.GetComponent<Renderer>();
        Slider.onValueChanged.AddListener(ChangeColor);
        //reset color
        ChangeColor(Slider.value);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //change ship color
    public void ChangeColor(float c)
    {
        rShip.material.color = Color.HSVToRGB(c, 1, 1);
    }
}
