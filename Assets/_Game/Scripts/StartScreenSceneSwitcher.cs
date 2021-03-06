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
            // Check if more than one scene before changing
            if (SceneManager.sceneCount > 1)
            {
                // Load scene at index 1
                SceneManager.LoadScene(1);
            }
        }
    }
}
