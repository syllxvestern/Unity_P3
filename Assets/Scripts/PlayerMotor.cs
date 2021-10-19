using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 moveVector;
    // Start is called before the first frame update
    private float speed = 5.0f;
    private float verticalVelocity = 0.0f;
    private float gravity = 12.0f;
    private float animationDuration = 2.0f;

    void Start()
    {
        controller = GetComponent<CharacterController> ();
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time < animationDuration)
        {
            controller.Move(Vector3.forward * speed * Time.deltaTime);
            return;
        }

        moveVector = Vector3.zero;

        if (controller.isGrounded)
        {
            verticalVelocity = -0.5f;
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }

        // x - Left and right
        moveVector.x = Input.GetAxisRaw("Horizontal") * speed;
        // y - Up and down
        moveVector.y = verticalVelocity;
        // z - Forward and Backward
        moveVector.z = speed;

        controller.Move(moveVector * Time.deltaTime);
    }
}
