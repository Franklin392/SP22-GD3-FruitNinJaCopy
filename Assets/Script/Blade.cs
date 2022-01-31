using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{
    private Rigidbody2D RB;
    public Camera cam;
    CircleCollider2D circleCollider;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        circleCollider = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        RB.position = cam.ScreenToWorldPoint(Input.mousePosition);
        if(Input.GetMouseButtonDown(0))
        {
            circleCollider.enabled = true;
        }
        else if(Input.GetMouseButtonUp(0))
        {
            circleCollider.enabled = false;
        }
    }
    
}
