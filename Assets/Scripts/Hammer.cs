using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour
{
    private Rigidbody rb;
    private UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable xr;
    public float umbralVelocidad;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        xr = GetComponent<UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable>();
    }

    // Update is called once per frame
    void Update()
    {
        if(rb.velocity.magnitude > umbralVelocidad)
        {
            xr.movementType = UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable.MovementType.VelocityTracking;
        }
        else
        {
            xr.movementType = UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable.MovementType.Kinematic;
        }
    }
}
