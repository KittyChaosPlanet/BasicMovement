using UnityEngine;
using System.Collections;

public class WizardVoice : MonoBehaviour
{
    public AudioSource myAudio;
    public float DelayAmount = 5000f;
    // Use this for initialization
    void Start()
    {

        StartCoroutine(PlaySoundAfterDelay(myAudio, DelayAmount));
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator PlaySoundAfterDelay(AudioSource audioSource, float delay)
    {
        if (audioSource == null)
            yield break;
        yield return new WaitForSeconds(delay);
        audioSource.Play();
    }

}