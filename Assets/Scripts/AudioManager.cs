using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    private AudioSource audioSource = null;
    public AudioClip SE0;
    public AudioClip SE1;
    public AudioClip SE2;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)||Input.GetKeyDown(KeyCode.D))
        {
            Walk();
        }
        if(Input.GetKeyDown(KeyCode.Return))
        {
            Throw();
        }
    }

    public void PlaySE(AudioClip clip)
    {
        if (audioSource != null)
        {
            audioSource.PlayOneShot(clip);
        }
        else
        {
            Debug.Log("audiosource=null");
        }
    }

    public void Walk()
    {
        PlaySE(SE0);
    }

    public void Throw()
    {
        PlaySE(SE1);
    }
}
