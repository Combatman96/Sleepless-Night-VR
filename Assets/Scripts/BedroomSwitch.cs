using UnityEngine;

public class BedroomSwitch : MonoBehaviour
{
    public Transform switchNob;
    
    public Vector3 off;
    public Vector3 on;

    private bool isOn = false;
    public void DialSwitch()
    {
        isOn = !isOn;
        GetComponent<AudioSource>().Play();
        if(isOn){
            switchNob.localPosition = on;
        }
        else{
            switchNob.localPosition = off;
        }
    }

}
