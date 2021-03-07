using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerOnDestroyRestart : MonoBehaviour
{
    void OnDestroy()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}