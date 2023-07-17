using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System;

public class CSVRequest : MonoBehaviour
{
    private class MonoBehaviourRequest : MonoBehaviour { }

    private static MonoBehaviourRequest WebRequestMonoBehaviour;

    private static void Init()
    {
        if (WebRequestMonoBehaviour == null)
        {
            GameObject gameobject = new GameObject("WebRequests");
            WebRequestMonoBehaviour = gameobject.AddComponent<MonoBehaviourRequest>();
        }
    }

    public static void ConectaUrl(string link, Action<string> onError, Action<string> onSuccess)
    {
        Init();
        WebRequestMonoBehaviour.StartCoroutine(Get(link, onError, onSuccess));
    }

    private static IEnumerator Get(string url, Action<string> onError, Action<string> onSuccess)
    {
        using (UnityWebRequest www = UnityWebRequest.Get(url))
        {
            // Env�a la solicitud y espera la respuesta
            yield return www.SendWebRequest();

            // Comprueba si hay alg�n error
            if (www.result != UnityWebRequest.Result.Success)
            {
                onError(www.error);
            }
            else
            {
                // Creamos un SubString con la informaci�n en el campo "promedio" (es ahi donde estan el promedio)
                // Encontrar el �ndice de inicio del campo "Promedio"
                int startIndex = www.downloadHandler.text.IndexOf("Promedio;");
                if (startIndex != -1)
                {
                    // Ajustar el �ndice de inicio
                    startIndex += 9;

                    // Encontrar el �ndice de cierre del campo "promedio" buscando ';'
                    int endIndex = www.downloadHandler.text.IndexOf(';', startIndex);

                    if (endIndex != -1)
                    {
                        // Crear el substring que contiene solo el campo "promedio"
                        string fields = www.downloadHandler.text.Substring(startIndex, endIndex - startIndex);
                        onSuccess(fields);
                    }
                    else
                    {
                        Debug.Log("Final no encontrado");
                    }
                }
                else
                {
                    Debug.Log("Inicio no encontrado");
                }
            }
        }
    }
}