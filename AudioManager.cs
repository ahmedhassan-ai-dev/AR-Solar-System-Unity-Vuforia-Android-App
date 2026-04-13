using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public Image buttonImage;
    public Sprite soundOnIcon;
    public Sprite soundOffIcon;

    private bool isMuted = false;

    void Start()
    {
        if (audioSource != null)
            audioSource.Play();

        if (buttonImage != null)
            buttonImage.sprite = soundOnIcon;
    }

    public void ToggleSound()
    {
        isMuted = !isMuted;

        if (audioSource != null)
            audioSource.mute = isMuted;

        if (buttonImage != null)
            buttonImage.sprite = isMuted ? soundOffIcon : soundOnIcon;
    }
}
