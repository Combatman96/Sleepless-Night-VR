using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [Header("Related GameObjects")]
    public GameObject parent;
    public GameObject model;
    private Animator animator;

    [Header("Properties")]
    public int /* Item */ keyId;
    private bool is_unlocked = false;

    void Start()
    {
        animator = parent.GetComponent<Animator>();
    }

    void Update()
    {
    }

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player" && !is_unlocked /* && Player holds keyId */) // Player must have Rigidbody
        {
            Debug.Log("Door unlocked");
            is_unlocked = true;
            animator.SetBool("is_unlocked", true);
            GetComponent<AudioSource>().enabled = true;
        }
        else
        {
            Debug.Log("Door locked");
        }
    }
}
