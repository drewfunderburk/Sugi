using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour
{
    public AudioSource Broken;
    public AudioSource MadeWhole;
    public AudioSource Pieces;

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void Awake()
    {
        DontDestroyOnLoad(this);
    }
    public void StopAll()
    {
        Broken.Stop();
        MadeWhole.Stop();
        Pieces.Stop();
    }

    public void PlayPieces()
    {
        StopAll();
        Pieces.Play();
    }
    public void PlayBroken()
    {
        StopAll();
        Broken.Play();
    }

    public void PlayMadeWhole()
    {
        StopAll();
        MadeWhole.Play();
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("CreditsScene"))
        {
            Debug.Log("Credits");
            PlayMadeWhole();
        }
    }

}
