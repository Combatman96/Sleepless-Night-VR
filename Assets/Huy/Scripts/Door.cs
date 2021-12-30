using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    const float CLOCKWISE = 90f, COUNTER_CLOCKWISE = -90f;

    [Header("Related GameObjects")]
    public GameObject parent;
    public GameObject view;

    [Header("Properties")]
    public int /* Item */ keyId;
    public float rotateTarget = CLOCKWISE;
    public float rotateSpeed = 0.1f;
    private bool is_unlocked = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion startRotation = parent.transform.rotation;
        Quaternion endRotation;
        endRotation = Quaternion.Euler(new Vector3(0, rotateTarget, 0));

        if ((is_unlocked) && parent.transform.rotation != endRotation)
        {
            Debug.Log(parent.transform.rotation.y + " AND " + endRotation);
            /*parent.transform.Rotate(new Vector3(0, rotateTarget, 0), rotateSpeed * Time.deltaTime);*/
            parent.transform.rotation = Quaternion.Slerp(startRotation, endRotation, rotateSpeed);
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player" && !is_unlocked /* && Player holds keyId */) // Player must have Rigidbody
        {
            Debug.Log("Door unlocked");
            is_unlocked = true;
        }
        else
        {
            Debug.Log("Door locked");
        }
    }
}
