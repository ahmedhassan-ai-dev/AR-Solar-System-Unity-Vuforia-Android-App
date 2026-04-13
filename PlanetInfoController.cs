using UnityEngine;
using UnityEngine.UI;

public class PlanetInfoController : MonoBehaviour
{
    public GameObject panel;
    public Image image;

    private bool isVisible = false;

    public void ToggleInfo(Sprite sprite)
    {
        if (panel.activeSelf && image.sprite == sprite)
        {
            panel.SetActive(false);
            isVisible = false;
        }
        else
        {
            panel.SetActive(true);
            image.sprite = sprite;
            isVisible = true;
        }
    }

    public void HideCompletely()
    {
        panel.SetActive(false);
        isVisible = false;
    }
}