using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //VARIABLES
    [SerializeField] private float mouseSensitivity;

    //REFERENCES
    private Transform parent;

    private void Start()
    {
        //assigning parent object which we want to rotate (player object)
        parent = transform.parent;

        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        //get input from mouse 
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;

        parent.Rotate(Vector3.up, mouseX);
    }
}
