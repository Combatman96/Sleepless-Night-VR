using UnityEngine;
using TMPro;
public class Inventory : MonoBehaviour
{
    public TextMeshProUGUI inventoryLabel;
    private bool[] keys = new bool[4];
    /*
    0 bedroom key
    1 fuze box key
    2 main drawer key
    3 main door key 
    */

    private void Start() {
        for (int i = 0; i < 4; i++ ){
            keys[i] = false;
        }
    }

    public void AddKey(int k){
        keys[k] = true;

        string temp = "";

        switch(k){
            case 0:
                temp = "Bedroom key";
                break;
            case 1:
                temp = "Fuzebox key";
                break;
            case 2:
                temp = "Main drawer key";
                break;
            case 3:
                temp = "Main door key";
                break;        
        }
        inventoryLabel.text = temp;
    }

    public void DiscardKey(){
        inventoryLabel.text = "";
    }

}
