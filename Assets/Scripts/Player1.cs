using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private CharacterController characterController;
    private Animator animator;

    public new Transform camera;
    public float speed = 4;
    public float gravity = -9.8f;
    //Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 movement = Vector3.zero;
        float moventSpeed = 0;

        //Vector3 Direction = new Vector3(horizontalInput, 0, verticalInput);

        if (hor != 0 || ver != 0) {
            Vector3 forward = camera.forward;
            forward.y = 0;
            forward.Normalize();

            Vector3 right = camera.right;
            right.y = 0;
            right.Normalize();

            Vector3 Direction = forward * ver + right * hor;
            moventSpeed = Mathf.Clamp01(Direction.magnitude);
            Direction.Normalize();
            movement = Direction * speed *moventSpeed* Time.deltaTime;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Direction), 0.1f);
        }

        movement.y += gravity * Time.deltaTime;
        characterController.Move(movement);
        animator.SetFloat("Xspeed", moventSpeed);
        
    }

}

