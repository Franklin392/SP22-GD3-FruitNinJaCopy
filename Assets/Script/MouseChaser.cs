using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseChaser : MonoBehaviour
{

    public Camera gameCamera;

    // Update is called once per frame
    void Update()

    { Vector2 mousePositionScreen = Input.mousePosition;

        //Vector3 worldPositionOfMouse = gameCamera.ScreenToWorldPoint();

        transform.position = Input.mousePosition;
    }
}
