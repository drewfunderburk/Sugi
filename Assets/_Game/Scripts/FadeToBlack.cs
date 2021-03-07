using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeToBlack : MonoBehaviour
{
    public Image image;

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        StartCoroutine(FromBlack(0.8f));
    }

    public IEnumerator FromBlack(float duration)
    {
        image.color = Color.black;
        float fadeAmount;
        while (image.color.a > 0)
        {
            fadeAmount = image.color.a - (duration * Time.deltaTime);
            image.color = new Color(0, 0, 0, fadeAmount);
            yield return null;
        }
    }

    public IEnumerator ToBlack(float duration)
    {
        image.color = new Color(0, 0, 0, 0);
        float fadeAmount;
        while (image.color.a < 1)
        {
            fadeAmount = image.color.a + (duration * Time.deltaTime);
            image.color = new Color(0, 0, 0, fadeAmount);
            yield return null;
        }
    }
}
