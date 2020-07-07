using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Range(1,1000)]
    public float speed = 10;
    public float turn = 5;
    float time = 120;

    public delegate void D_PlayerEvent() ;
    public event D_PlayerEvent onDead;
    public event D_PlayerEvent onItem;
    public event D_PlayerEvent onFinal;

    private Rigidbody rig;
    Transform cam;





    void Move() {
        float v = Input.GetAxis("Vertical")/10;
        float h = Input.GetAxis("Horizontal")/10;
        rig.AddForce(cam.forward * v * speed + cam.right * h * speed);

        float x = Input.GetAxis("Mouse X");
        cam.Rotate(0, x * turn, 0);    
    }









    private void Awake()
    {
        rig = GetComponent<Rigidbody>();
        cam = transform.GetChild(0);
    }

    private void FixedUpdate()
    {
        Move();

    }
}
