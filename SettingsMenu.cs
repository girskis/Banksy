using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioMixer audioMixer;
     public void SetVolume (float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

}
