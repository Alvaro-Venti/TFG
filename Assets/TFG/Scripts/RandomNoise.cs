using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNoise : MonoBehaviour
{
    public AudioSource source;
    public AudioClip[] clips;

    private bool sonando = false;

    public void playRandomNoise(float intensity)
    {
        if (!sonando)
        {
            source.PlayOneShot(clips[Random.Range(0, 6)], intensity);
            StartCoroutine(sonar());
        }

        IEnumerator sonar()
        {
            sonando = true;
            yield return new WaitForSeconds(10);
            sonando = false;
        }  
    }
}
