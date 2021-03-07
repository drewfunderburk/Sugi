using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartScreenSceneSwitcher : MonoBehaviour
{
    void Update()
    {
        // If any key or mouse button pressed
        if (Input.anyKeyDown)
        {
            // Load next scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
