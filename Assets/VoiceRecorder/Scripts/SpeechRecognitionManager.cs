using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeechRecognitionManager : MonoBehaviour
{
	public string language = "es_ES";
	
	public string listeningMessage = "Escuchando...";
	private AndroidJavaClass pluginClass;
	
	public string[] commands = {"encender", "apagar"};
	public List<GameObject> targets;
	
	public int minLevenshteinDistance = -1;
	public Text uiTextDebug;


	public void promptSpeechInput()
	{

	}
    public void detect(string recognizedText){
	    string[] result = recognizedText.Split(' ');
        string response = detectCommand(result);
        if(uiTextDebug)
	        uiTextDebug.text = response;
        else
        {
	        Debug.Log(response);
        }
		
    }

    string detectCommand(string[]words)
    {
	    if (commands.Length == 0 || targets.Count == 0) return "No tengo comandos y/o objetos";
	    string command=commands[0];
	    GameObject obj=targets[0] as GameObject;
	    
	    int distCommand = LevenshteinDistance.Compute(words[0], command);
	    foreach (var word in words)
	    {
		    foreach (var cmd in commands)
		    {
			    int d = LevenshteinDistance.Compute(word, cmd);
			    if (d < distCommand)
			    {
				    distCommand = d;
				    command = cmd;
			    }
		    }
	    }

	    string[] wordsTarget = obj.name.Split(' ');
	    int distTarget = LevenshteinDistance.Compute(words, 0, wordsTarget, wordsTarget.Length);
	    for (int i = 1; i < words.Length; i++)
	    {
		    foreach (GameObject o in targets)
			    
		    {
			    wordsTarget = o.name.Split(' ');
			    int d = LevenshteinDistance.Compute(words, i, wordsTarget,wordsTarget.Length);
			    if (d < distTarget)
			    {
				    distTarget = d;
				    obj = o;
			    }
		    }
	    }
	    if (minLevenshteinDistance == -1 ||
	        (minLevenshteinDistance < distCommand && minLevenshteinDistance < distTarget))
	    {
		    obj.SendMessage(command);
		    return "Detectado " + command + " sobre el objeto " + obj.name + "con distancia "+distCommand+" y "+distTarget+".";
	    }
	    else
	    {
		    return "No sé de qué me hablas...";
	    }
    }
}
