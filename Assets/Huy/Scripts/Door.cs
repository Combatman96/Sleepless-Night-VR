using UnityEngine;
using TMPro;
public class Door : MonoBehaviour
{
    [Header("Related GameObjects")]
    public GameObject parent;
    public GameObject model;
    public TextMeshProUGUI inventoryLabel;
    public Collider boxCollider;
    private Animator animator;

    private AudioSource doorSfx;

    [Header("Properties")]
    public int /* Item */ keyId;
    public Inventory inventory;
    private bool is_unlocked = false;

    void Start()
    {
        animator = parent.GetComponent<Animator>();
        doorSfx = GetComponent<AudioSource>();
    }

    public void OpenTheDoor()
    {
        if(inventory.getKey(keyId)){
            animator.SetBool("is_unlocked", true);
            doorSfx.Play();
            inventory.DiscardKey(keyId);
            boxCollider.enabled = false;
        }
        else{
            inventoryLabel.text = "Door locked";
        }
    }

    // private void OnTriggerEnter(Collider collider)
    // {
    //     if(collider.gameObject.tag == "Player" && !is_unlocked /* && Player holds keyId */) // Player must have Rigidbody
    //     {
    //         Debug.Log("Door unlocked");
    //         is_unlocked = true;
    //         animator.SetBool("is_unlocked", true);
    //         GetComponent<AudioSource>().enabled = true;
    //     }
    //     else
    //     {
    //         Debug.Log("Door locked");
    //     }
    // }


}
