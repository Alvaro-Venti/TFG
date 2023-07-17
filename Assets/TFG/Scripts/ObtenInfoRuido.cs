using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObtenInfoRuido : MonoBehaviour
{
    [SerializeField] private string url;
    [SerializeField] private RandomNoise randomNoise;

    public void Sonar()
    {
        CSVRequest.ConectaUrl(url, (string error) =>
        {
            // Error
            Debug.Log("Error: " + error);
        }, (string text) =>
        {
            // Successfully contacted URL
            Debug.Log("Success: " + text);
            //Debug.Log(float.Parse(text) / 100); 
            randomNoise.playRandomNoise(float.Parse(text) / 100);
        });
    }

}