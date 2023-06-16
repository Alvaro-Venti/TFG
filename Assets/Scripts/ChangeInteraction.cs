using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class ChangeInteraction : MonoBehaviour
{
    private ActionBasedControllerManager ac;
    [SerializeField] GameObject DirectController;
    [SerializeField] GameObject RayController;

    private void Start() 
    {
        ac = GetComponent<ActionBasedControllerManager>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if((other.gameObject.name == "ArcadeGun_right" && gameObject.name=="RightHand")||(other.gameObject.name == "ArcadeGun_left" && gameObject.name=="LeftHand"))
        {
            other.GetComponent<MeshRenderer>().enabled = !other.GetComponent<MeshRenderer>().enabled;

            if(other.GetComponent<MeshRenderer>().enabled)
            {
                ac.baseControllerGameObject = DirectController;
            }
            else
            {
                ac.baseControllerGameObject = RayController;
            }
        }
    }
}
