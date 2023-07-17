using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCamera : MonoBehaviour
{
    public float Xsens;
    public float Ysens;

    public Transform orientation;

    float Xrotation;
    float Yrotation;
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    
    }
    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * Xsens;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * Ysens;

        Yrotation += mouseX;
        Xrotation -= mouseY;
        Xrotation = Mathf.Clamp(Xrotation, -90f, 90f);

        transform.rotation = Quaternion.Euler(Xrotation, Yrotation, 0);
        orientation.rotation = Quaternion.Euler(0, Yrotation, 0);
    }
}
