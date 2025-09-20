using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;  
    public AudioSource coinCollectSound; 

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);  
        }
    }
    private void Start()
    {
        Debug.Log("AudioManager Start called");
        coinCollectSound.Stop();
    }

    public void PlayCoinCollectSound()
    {
        Debug.Log("Coin collect sound played!");  
        coinCollectSound.Play(); 
    }

    public AudioSource bombFailSound;

    public void PlayBombFailSound()
    {
        bombFailSound.Play();
    }


}
