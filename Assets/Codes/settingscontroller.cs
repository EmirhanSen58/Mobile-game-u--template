using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class OpenSettings : MonoBehaviour, IPointerClickHandler
{
    // Bu fonksiyon, butona t�klan�ld���nda �al��t�r�lacak
    public void OpenSettingsScene()
    {
        SceneManager.LoadScene("SettingsScene"); // "SettingsScene" sahne ad�d�r, kendi sahne ad�n�z� buraya yaz�n
    }

    // Bu fonksiyon, kullan�c� elle t�klama yapt���nda �al���r
    public void OnPointerClick(PointerEventData eventData)
    {
        OpenSettingsScene();
    }

    // Bu fonksiyon, geli�tirici modunda �al���rken mouse t�klamas�n� kontrol eder
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Mouse sol tu�una bas�ld���nda
        {
            // E�er UI ��elerinin �zerine t�klanmad�ysa sahneyi a�
            if (!EventSystem.current.IsPointerOverGameObject())
            {
                OpenSettingsScene();
            }
        }
    }
}
