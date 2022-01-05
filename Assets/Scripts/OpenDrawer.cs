using UnityEngine;
using TMPro;
public class OpenDrawer : MonoBehaviour
{
    [Header("Preferences")]
    public Transform drawer;
    public Inventory inventory;
    public TextMeshProUGUI itemLabel;


    [Header("Properties")]
    public bool unlocked = true;
    public float openingSpeed = 3f;
  
    private bool isOpen = false;
    private int num = 0;
    private Vector3 openPos;
    public void Open()
    {
        if(num == 0 && unlocked)
        {
            isOpen = true;
            openPos = drawer.localPosition + new Vector3(0.35f, 0f, 0f);
            Debug.Log(openPos);
            num++;
        }

        if(!unlocked)
        {
            if(inventory.getKey(2) && num == 0)
            {
                isOpen = true;
                openPos = drawer.localPosition + new Vector3(0.35f, 0f, 0f);
                Debug.Log(openPos);
                num++;
            }
            else 
            {
                itemLabel.text = "Locked"; 
            }
        }
    }

    private void Update() {
        if(isOpen){
            drawer.localPosition = Vector3.MoveTowards(drawer.localPosition, openPos, openingSpeed*Time.deltaTime);
        }
    }
}
