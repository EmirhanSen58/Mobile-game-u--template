using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class OpenSettings : MonoBehaviour, IPointerClickHandler
{
    // Bu fonksiyon, butona týklanýldýðýnda çalýþtýrýlacak
    public void OpenSettingsScene()
    {
        SceneManager.LoadScene("SettingsScene"); // "SettingsScene" sahne adýdýr, kendi sahne adýnýzý buraya yazýn
    }

    // Bu fonksiyon, kullanýcý elle týklama yaptýðýnda çalýþýr
    public void OnPointerClick(PointerEventData eventData)
    {
        OpenSettingsScene();
    }

    // Bu fonksiyon, geliþtirici modunda çalýþýrken mouse týklamasýný kontrol eder
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Mouse sol tuþuna basýldýðýnda
        {
            // Eðer UI öðelerinin üzerine týklanmadýysa sahneyi aç
            if (!EventSystem.current.IsPointerOverGameObject())
            {
                OpenSettingsScene();
            }
        }
    }
}
