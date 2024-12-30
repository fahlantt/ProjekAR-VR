using UnityEngine;

public class ChangeTo3D : MonoBehaviour
{
    public GameObject model3D; // Objek 3D yang akan diaktifkan/dinonaktifkan
    public GameObject model2D; // Objek 2D untuk ditampilkan kembali jika diperlukan

    // Fungsi untuk menampilkan objek 3D
    public void Show3DObject()
    {
        if (model3D != null)
        {
            model3D.SetActive(true);
        }
        else
        {
            Debug.LogWarning("Model 3D is not assigned!");
        }

        if (model2D != null)
        {
            model2D.SetActive(false);
        }
    }

    // Fungsi untuk menghilangkan objek 3D
    public void Hide3DObject()
    {
        if (model3D != null)
        {
            model3D.SetActive(false);
        }
        else
        {
            Debug.LogWarning("Model 3D is not assigned!");
        }

        if (model2D != null)
        {
            model2D.SetActive(true);
        }
    }
}
