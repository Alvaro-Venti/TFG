using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using TMPro;

public class ObtenInfoAmbiental : MonoBehaviour
{
    [SerializeField] private string url;
    [SerializeField] private ParticleSystem sistema;
    //[SerializeField] private TextMeshProUGUI text;

    private DataAmbiental data;

    void Start()
    {
        var emission = sistema.emission;
        HTTPRequest.ConectaUrl(url, (string error) =>
        {
            // Error
            //text.text = error;
            Debug.Log("Error: " + error);
        }, (string text) =>
        {
            // Successfully contacted URL
            //Debug.Log("Success");
            data = DataAmbiental.LoadData(text);
            

            switch (data.calidad_ambiental)
            {
                case "Desfavorable":
                    Debug.Log("Desfavorable");
                    emission.rateOverTime = new ParticleSystem.MinMaxCurve(100);
                    break;

                case "Regular":
                    Debug.Log("Regular");
                    emission.rateOverTime = new ParticleSystem.MinMaxCurve(10);
                    break;

                case "Razonablemente Buena":
                    Debug.Log("Razonablemente Buena");
                    emission.rateOverTime = new ParticleSystem.MinMaxCurve(2);
                    break;

                case "Buena":
                    Debug.Log("Buena");
                    emission.rateOverTime = new ParticleSystem.MinMaxCurve(0);
                    break;
            }
        });
    }

}
