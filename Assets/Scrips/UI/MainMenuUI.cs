using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    private Transform _cameraTransform;
    
    public Transform developerSplashScreen;
    public Transform mainMenuDeveloperSplashScreen;
    
    public float transitionDuration = 0.5f;

    void Start()
    {
        if (Camera.main != null) _cameraTransform = Camera.main.transform;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.N))
        {
            Debug.Log("InputDetected");
            
            if (_cameraTransform.position == mainMenuDeveloperSplashScreen.position)
            {
                DeveloperScreenMove();
            }
            else if(_cameraTransform.position == developerSplashScreen.position)
            {
                MainScreenMove();
            }
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            
        }
    }

    public void Play()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadSceneAsync(sceneBuildIndex: 1);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void DeveloperScreenMove()
    {
        _cameraTransform.DOMove(developerSplashScreen.position, transitionDuration);
        _cameraTransform.DORotate(developerSplashScreen.rotation.eulerAngles, transitionDuration);
    }

    public void MainScreenMove()
    {
        _cameraTransform.DOMove(mainMenuDeveloperSplashScreen.position, transitionDuration);
        _cameraTransform.DORotate(mainMenuDeveloperSplashScreen.rotation.eulerAngles, transitionDuration);
    }

    public void OpenGitHub()
    {
        Application.OpenURL("https://github.com/KasaiRaito");
    }

    public void OpenItch()
    {
        Application.OpenURL("https://kasairaito.itch.io");
    }
}
