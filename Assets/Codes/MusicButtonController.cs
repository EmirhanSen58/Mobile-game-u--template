using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ToggleMusicButton : MonoBehaviour, IPointerClickHandler
{
    public Sprite musicOnSprite;  // M�zik a��kken kullan�lacak g�rsel
    public Sprite musicOffSprite; // M�zik kapal�yken kullan�lacak g�rsel
    private bool isMusicOn = true; // Ba�lang��ta m�zik a��k
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
            // M�zik a�ma kodu buraya
            Debug.Log("M�zik A��k");
        }
        else
        {
            // M�zik kapama kodu buraya
            Debug.Log("M�zik Kapal�");
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
        if (Input.GetMouseButtonDown(0)) // Mouse sol tu�una bas�ld���nda
        {
            // E�er UI ��elerinin �zerine t�klanmad�ysa sahneyi a�
            if (!EventSystem.current.IsPointerOverGameObject())
            {
                ToggleMusic();
            }
        }
    }
}
