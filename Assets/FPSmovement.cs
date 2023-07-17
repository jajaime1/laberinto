using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSmovement : MonoBehaviour
{
    public float Speed;
    public Transform orientation;
    float HorizontalInput;
    float VerticalInput;
    Vector3 MoveDirection;
    Rigidbody RB;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
        RB.freezeRotation = true;
    }

    private void Inputs()
    {
        HorizontalInput = Input.GetAxisRaw("Horizontal");
        VerticalInput = Input.GetAxisRaw("Vertical");
    }

    private void MovePlayer()
    {
        MoveDirection = orientation.forward * VerticalInput + orientation.right * HorizontalInput;
        RB.AddForce(MoveDirection.normalized * Speed * 5f, ForceMode.Force);

    }

    // Update is called once per frame
    void Update()
    {
        Inputs();
        MovePlayer();
    }
}
