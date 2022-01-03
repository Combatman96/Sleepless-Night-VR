using UnityEngine;

public class OpenDrawer : MonoBehaviour
{
    public Transform drawer;
    public float openingSpeed = 3f;
    private bool isOpen = false;
    private int num = 0;
    private Vector3 openPos;
    public void Open(){
        if(num == 0){
            isOpen = true;
            openPos = drawer.localPosition + new Vector3(0.35f, 0f, 0f);
            Debug.Log(openPos);
            num++;
        }
    }

    private void Update() {
        if(isOpen){
            drawer.localPosition = Vector3.MoveTowards(drawer.localPosition, openPos, openingSpeed*Time.deltaTime);
        }
    }
}
