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
            openPos = drawer.position + new Vector3(1.2f, 0f, 0f);
            num ++;
        }
    }

    private void Update() {
        if(isOpen){
            drawer.position = Vector3.MoveTowards(drawer.position, openPos, openingSpeed*Time.deltaTime);
        }
    }
}
