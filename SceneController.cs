using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Fungsi untuk pindah ke scene tertentu
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // Fungsi untuk kembali ke scene Home
    public void LoadHomeScene()
    {
        SceneManager.LoadScene("Home");
    }

    // Fungsi untuk keluar dari aplikasi
    public void ExitApplication()
    {
        Application.Quit();
        Debug.Log("Application Exited"); // Berfungsi hanya saat di editor, tidak akan muncul di build.
    }
}
