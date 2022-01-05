using UnityEngine;
using UnityEngine.SceneManagement;

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


    [Header("Flash Light")]
    public Light flashLight;

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
            controller.Move(move * speed * Time.deltaTime);
        }
       
        //Gravity
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        //This is how it end
        if(other.tag == "Enemy")
        {
            Debug.Log("Hello Oh no");
            SceneManager.LoadScene(2, LoadSceneMode.Single);
        }
    }

    public void TurnOnFlashLight(){
        flashLight.enabled = true;
    }

}
