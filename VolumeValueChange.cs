using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeValueChange : MonoBehaviour
{
    private AudioSource audioSrc;
    private float AudioPannel = 1f;

    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //audioSrc.volume = AudioPannel;
    }

    public void SetVolume(float vol)
    {
        AudioPannel = vol;
    }
}
