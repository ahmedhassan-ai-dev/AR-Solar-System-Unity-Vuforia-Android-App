using UnityEngine;

public class StartAR : MonoBehaviour
{
    public GameObject mainUI;
    public PlanetInfoController infoController;

    public void StartApp()
    {
        if (mainUI != null)
            mainUI.SetActive(false);

        if (infoController != null)
            infoController.HideCompletely();
    }
}
