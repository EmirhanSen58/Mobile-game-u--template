using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ToggleMusicButton : MonoBehaviour, IPointerClickHandler
{
    public Sprite musicOnSprite;  // Müzik açýkken kullanýlacak görsel
    public Sprite musicOffSprite; // Müzik kapalýyken kullanýlacak görsel
    private bool isMusicOn = true; // Baþlangýçta müzik açýk
    private Button button;
    private Image buttonImage;

    void Start()
    {
        button = GetComponent<Button>();
        buttonImage = button.GetComponent<Image>();
        button.onClick.AddListener(ToggleMusic);
        UpdateButtonImage();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        ToggleMusic();
    }

    void ToggleMusic()
    {
        isMusicOn = !isMusicOn;
        UpdateButtonImage();

        if (isMusicOn)
        {
            // Müzik açma kodu buraya
            Debug.Log("Müzik Açýk");
        }
        else
        {
            // Müzik kapama kodu buraya
            Debug.Log("Müzik Kapalý");
        }
    }

    void UpdateButtonImage()
    {
        if (isMusicOn)
        {
            buttonImage.sprite = musicOnSprite;
        }
        else
        {
            buttonImage.sprite = musicOffSprite;
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Mouse sol tuþuna basýldýðýnda
        {
            // Eðer UI öðelerinin üzerine týklanmadýysa sahneyi aç
            if (!EventSystem.current.IsPointerOverGameObject())
            {
                ToggleMusic();
            }
        }
    }
}
