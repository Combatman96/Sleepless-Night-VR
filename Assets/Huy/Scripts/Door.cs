using UnityEngine;
using TMPro;
public class Door : MonoBehaviour
{
    [Header("Related GameObjects")]
    public TextMeshProUGUI inventoryLabel;
    private Collider boxCollider;
    private Animator animator;

    private AudioSource doorSfx;

    [Header("Properties")]
    public bool unlocked = false;
    public int /* Item */ keyId;
    public Inventory inventory;

    void Start()
    {
        boxCollider = GetComponent<BoxCollider>();
        animator = GetComponent<Animator>();
        doorSfx = GetComponent<AudioSource>();
    }

    public void OpenTheDoor()
    {
        if(inventory.getKey(keyId) || unlocked){
            animator.SetBool("isOpen", true);
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
