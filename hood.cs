using UnityEngine;

public class OpenHood : MonoBehaviour
{
public float openAngle = 60f;
public float speed = 2f;


private Quaternion closedRotation;
private Quaternion openRotation;
private bool isOpen = false;

void Start()
{
    closedRotation = transform.localRotation;
    openRotation = Quaternion.Euler(-openAngle, 0, 0) * closedRotation;
}

void Update()
{
    if (Input.GetKeyDown(KeyCode.H))
    {
        isOpen = !isOpen;
    }

    if (isOpen)
    {
        transform.localRotation = Quaternion.Lerp(transform.localRotation, openRotation, Time.deltaTime * speed);
    }
    else
    {
        transform.localRotation = Quaternion.Lerp(transform.localRotation, closedRotation, Time.deltaTime * speed);
    }
}
}