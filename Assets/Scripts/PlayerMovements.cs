using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    [Header("Movements")]
    public CharacterController controller;
    public float speed = 12f;
    public float gravity = -9.81f;

    
    [Header("For Ground Checking")]
    public Transform groundCheck;
    public float groundDistance = 0.2f;
    public LayerMask groundMask;
    bool isGrounded;

    private Vector3 velocity;

    // Update is called once per frame
    void Update()
    {
        //Just for the ground check
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        
        //Touch and hold to move forward
        if (Input.touchCount > 0 || Input.GetMouseButton(0))
        {
            Vector3 move = Camera.main.transform.forward;
            move.y = 0;
            Debug.Log(move);

            controller.Move(move * speed * Time.deltaTime);
        }

        Debug.Log(Input.touchCount);
        
        //Gravity
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
