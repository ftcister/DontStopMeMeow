using Ludiq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerExample : MonoBehaviour
{
    public float speed;
    public FloatingJoystick floatingJoystick;
    public Rigidbody rb;

    public void FixedUpdate()
    {
        Vector3 horizontal = Vector3.right * floatingJoystick.Horizontal;
        rb.AddForce(horizontal * -speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
        Vector3 vertical = Vector3.up * floatingJoystick.Vertical;
        rb.AddForce(vertical * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
       
            
    }
}