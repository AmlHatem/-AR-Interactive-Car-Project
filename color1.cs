using UnityEngine;

public class ChangeCarColor : MonoBehaviour
{
Renderer carRenderer;


void Start()
{
    carRenderer = GetComponent<Renderer>();
}

void OnMouseDown()
{
    carRenderer.material.color = new Color(
        Random.value,
        Random.value,
        Random.value
    );
}


}