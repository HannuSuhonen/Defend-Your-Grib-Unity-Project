using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionsController : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    [SerializeField] float defaultVolume = 0.8f;

    private void Start() 
    {
        volumeSlider.value = PlayerPrefsController.GetMasterVolume();
    }

    private void Update() 
    {
        var musicPlayer = FindObjectOfType<MusicPlayer>();
        if(musicPlayer)
        {
            musicPlayer.SetVolume(volumeSlider.value);
        }
        else
        {
            Debug.LogWarning("No musicplayer found, did you start from Start Menu?");
        }
    }

    public void SaveAndExit()
    {
        PlayerPrefsController.SetMasterVolume(volumeSlider.value);
        SceneManager.LoadScene(1);
    }

    public void SetDefaults()
    {
        volumeSlider.value = defaultVolume;
    }
}
