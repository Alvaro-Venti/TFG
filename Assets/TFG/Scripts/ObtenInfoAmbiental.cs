using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObtenInfoAmbiental : MonoBehaviour
{
    [SerializeField] private string url;
    [SerializeField] private ParticleSystem sistema;

    private DataAmbiental data;

    void Start()
    {
        HTTPRequest.ConectaUrl(url, (string error) =>
        {
            // Error
            Debug.Log("Error: " + error);
        }, (string text) =>
        {
            // Successfully contacted URL
            Debug.Log("Success");
            data = DataAmbiental.LoadData(text);

            switch (data.calidad_ambiental)
            {
                case "Desfavorable":
                    //Debug.Log("Desfavorable");
                    sistema.Emit(100);
                    break;

                case "Regular":
                    //Debug.Log("Regular");
                    sistema.Emit(50);
                    break;

                case "Razonablemente Buena":
                    //Debug.Log("Razonablemente Buena");
                    sistema.Emit(10);
                    break;

                default:
                    //Debug.Log("Buena");
                    sistema.Emit(0);
                    break;
            }
        });
    }

}
