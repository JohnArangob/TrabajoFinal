using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController characterController;
    private Animator animator;

    [SerializeField]
    new Transform camera;

    [SerializeField]
    float speed = 2;

    [SerializeField]
    float gravity = -9.8f;

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
        float moveSpeed = 0;

        if (hor != 0 || ver != 0)
        {
            Vector3 forward = camera.forward;
            forward.y = 0;
            forward.Normalize();

            Vector3 right = camera.right;
            right.y = 0;
            right.Normalize();

            Vector3 direction = forward * ver + right * hor;
            moveSpeed = Mathf.Clamp01(direction.magnitude);
            direction.Normalize();
            movement = moveSpeed * speed * Time.deltaTime * direction;

            // Ajusta la rotación solo si hay un cambio en la dirección
            if (direction != Vector3.zero)
            {
                transform.rotation = Quaternion.Slerp(
                    transform.rotation,
                    Quaternion.LookRotation(direction),
                    0.1f
                );
            }
        }

        movement.y += gravity * Time.deltaTime;
        characterController.Move(movement);
        animator.SetFloat("Xspeed", moveSpeed);
    }
}
