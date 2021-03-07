using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartScreenSceneSwitcher : MonoBehaviour
{
    public FadeToBlack fadeToBlack;
    void Update()
    {
        // If any key or mouse button pressed
        if (Input.anyKeyDown)
        {
            // Load next scene
            StartCoroutine(nextScene());
        }
    }

    IEnumerator nextScene()
    {
        StartCoroutine(fadeToBlack.ToBlack(0.8f));
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
