using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
    public TMP_Dropdown resolutionDrop;
    Resolution[] rezArray;

    public AudioMixer audioMixer;

    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("MasterVolume", volume);
          
    }

    private void Start()
    {
        rezArray = Screen.resolutions;
        resolutionDrop.ClearOptions();                                        //clear out dummy options

        List<string> options = new List<string>();                            //create new list of strings
        int currentResolutionIndex = 0;
        for (int i = 0; i < rezArray.Length; i++)                             //looping through rezArray and 
        {                                                                     //add every resolution as a string
            string option = rezArray[i].width + " x " + rezArray[i].height;
            options.Add(option);

            if(rezArray[i].width == Screen.currentResolution.width &&         //for current resolution
                rezArray[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

        resolutionDrop.AddOptions(options);                                   //Add resolutions to drop down
        resolutionDrop.value = currentResolutionIndex;
        resolutionDrop.RefreshShownValue();
    }

    public void SetResolution (int resolutionIndex)
    {
        Resolution resolution = rezArray[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void SetQuality (int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex+1);
    }

    public void SetFullscreen (bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }
}
