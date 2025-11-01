using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SplashScreen : MonoBehaviour
{
    void Awake()
    {
#if !UNITY_EDITOR
        PlayerPrefs.SetInt("UnitySelectMonitor", 0); // Select monitor at index
#endif
#if UNITY_EDITOR
        Debug.Log("Splash screen opened");
#endif        
    }
}
