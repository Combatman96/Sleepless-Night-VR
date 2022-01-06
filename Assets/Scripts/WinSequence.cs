using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class WinSequence : MonoBehaviour
{
    [Header("Sound FX")]
    public AudioSource doorSfx;
    
    [Header("Animations")]
    public Animation doorOpen;
    public Animation cameraForward;
    public Animation textFade1;
    public Animation textFade2;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TheSequence());
    }

    IEnumerator TheSequence()
    {
        yield return new WaitForSeconds(1);
        doorSfx.Play();
        doorOpen.Play("door_open");
        
        yield return new WaitForSeconds(3);
        cameraForward.Play("camera_forward");
        
        yield return new WaitForSeconds(5);
        textFade1.Play("text1_fade");

        yield return new WaitForSeconds(4);
        textFade2.Play("text1_fade");

        yield return new WaitForSeconds(6);
        //Load back to Title Screen 
        SceneManager.LoadScene(0, LoadSceneMode.Single);
        
    }
}
