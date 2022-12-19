using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundActivationButton : MonoBehaviour
{
    public AudioClip soundClip; // audio clip to play when button is clicked
    public AudioSource audioSource; // audio source component to play the sound
    public Image completionIndicator; // image game object to use as a visual indicator
    public GameObject panel; // panel game object to display when button is clicked
    public GameObject NextButton; // NextButton game object to enable when audio clip stops playing

    // method called when button is clicked
    public void PlaySound()
    {
        // play the sound clip using the audio source
        audioSource.PlayOneShot(soundClip);

        // start a coroutine to enable the panel game object and the checkmark image when the audio clip stops playing
        StartCoroutine(EnableUIWhenAudioStopsPlaying());
    }

    IEnumerator EnableUIWhenAudioStopsPlaying()
    {
        // wait until the audio clip finishes playing
        while (audioSource.isPlaying)
        {
            yield return null;
        }

        // enable the panel game object and the checkmark image
        panel.gameObject.SetActive(true);
        completionIndicator.gameObject.SetActive(true);

        // enable the NextButton game object
        NextButton.gameObject.SetActive(true);
    }
}