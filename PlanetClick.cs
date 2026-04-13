using UnityEngine;

public class PlanetClick : MonoBehaviour
{
    public Sprite planetImage;
    public PlanetInfoController controller;

    void Update()
    {
        // Mobile
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            HandleTouch(Input.GetTouch(0).position);
        }

        // Editor
        if (Input.GetMouseButtonDown(0))
        {
            HandleTouch(Input.mousePosition);
        }
    }

    void HandleTouch(Vector2 pos)
    {
        Ray ray = Camera.main.ScreenPointToRay(pos);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform == transform)
            {
                if (controller != null)
                    controller.ToggleInfo(planetImage);
            }
        }
    }
}