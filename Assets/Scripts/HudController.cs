using UnityEngine;
using TMPro;
public class HudController : MonoBehaviour
{

    /*
    
    0 bedroom key
    1 fuze box key/ basement key
    2 main drawer key
    3 main door key 
    4 flash light
    5 door
    6 locker
    7 fuze box
    8 newpaper
    9 family Photo
    10 OpenWindow
    11 Knive Sheves
    12 Landline Telephone
    13 Radio
    14 Milk
    
    */

    [Header("References")]
    public TextMeshProUGUI itemLabel;

    public void PointerFocus(int item)
    {
        string temp = "";
        switch(item)
        {
            case 0:
                temp = "Bedroom key";
                break;
            case 1:
                temp = "Examine"; // the key to the basement is in the tool box
                break;
            case 2:
                temp = "Examine"; // the father body contain the key to the living room chest
                break;
            case 3:
                temp = "Main door key";
                break;
            case 4:
                temp = "Flash light";
                break;
            case 5: 
                temp = "Door";
                break;
            case 6: 
                temp = "Drawer";
                break;
            case 7:
                temp = "Reconnect the fuse";
                break;
            case 8:
                temp = "Newpaper";
                break;
            case 9:
                temp = "Family Photo";
                break;
            case 10:
                temp = "Window";
                break;
            case 11:
                temp = "Knives";
                break;
            case 12:
                temp = "Telephone";
                break;
            case 13:
                temp = "Radio";
                break;
            case 14:
                temp = "Milk";
                break;    
            case 15:
                temp = "Exit";
                break;
            case 16:
                temp = "Light switch";
                break;
        }
        itemLabel.SetText(temp);
    }

    public void PointerOutFocus(){
        itemLabel.SetText("");
    }

    public void RelayDetail(int item){
        string details = "";

        switch(item){
            case 8:
                details = "Unidentified male breaked in and killed a family... Scary!";
                break;
            case 9:
                details = "Dad looks younger in the photo.";
                break;
            case 10:
                details = "Did I forget to close the window? Can't remenber.";
                break;
            case 11:
                details = "Weird! One is missing.";
                break;
            case 12:
                details = "No signal. Must be the storm.";
                break;
            case 14:
                details = "This milk smells like cheese.";
                break;
        }

        itemLabel.SetText(details);
    }
}
