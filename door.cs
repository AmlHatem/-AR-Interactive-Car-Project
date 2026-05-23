using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    bool open = false;

    void OnMouseDown()
    {
        if (open == false)
        {
            transform.Rotate(0, 70, 0);
            open = true;
        }
        else
        {
            transform.Rotate(0, -70, 0);
            open = false;
        }
    }
}