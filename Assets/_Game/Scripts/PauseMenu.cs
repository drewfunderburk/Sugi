using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject panel;

    bool isPaused = false;

    void Update()
    {
        // If escape is pressed
        if (Input.GetButtonUp("Cancel"))
        {
            // Check if we are paused
            if (!isPaused)
            {
                // Pause game
                OnPause();
                isPaused = true;
            }
            else
            {
                // Unpause game
                OnContinue();
                isPaused = false;
            }
        }
    }
    public void OnPause()
    {
        // Show Panel
        panel.SetActive(true);
        // Set timescale to 0
        Time.timeScale = 0.000001f;
    }
    public void OnContinue()
    {
        // Set timescale to 1
        Time.timeScale = 1;
        // Hide Panel
        panel.SetActive(false);
    }

    public void OnRestart()
    {
        // Restart
        Restart();
    }

    public void OnQuit()
    {
        // Quit
        Quit();
    }

    void Restart()
    {
        // Set timescale to 1
        Time.timeScale = 1;
        // Load the active scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void Quit()
    {
        // If we're in the editor, exit play m ode
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        // If we're in an application, quit
        #else
            Application.Quit();
        #endif
    }
}
