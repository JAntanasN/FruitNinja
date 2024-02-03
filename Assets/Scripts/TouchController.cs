using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
    public Transform cursor;
    private bool isTouching;
    private Camera mainCamera;


    public void Start()
    {
        mainCamera = Camera.main;
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) 
        { 
            isTouching = true;
            cursor.gameObject.SetActive(true);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            isTouching = false;
            cursor.gameObject.SetActive(false);
        }

        if (isTouching) 
        {
            var mouseposition = Input.mousePosition;

            mouseposition.z = - mainCamera.transform.position.z;

            var worldposition = mainCamera.ScreenToWorldPoint(mouseposition);

            cursor.position = worldposition;
        }
    }
}
