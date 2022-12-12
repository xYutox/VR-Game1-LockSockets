using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SocketEvent : XRSocketInteractor
{
    // XRBaseInteractable interactable = gameObject.GetComponent<XRBaseInteractable>();

    //public void CheckObjectTag()
    //{
    //    XRSocketInteractor socket = gameObject.GetComponent<XRSocketInteractor>();
    //    XRBaseInteractable interactable = gameObject.GetComponent<XRBaseInteractable>();

    //    // check socket tag
    //    if (socket.CompareTag("SocketMotherboard"))
    //    {
    //        // check object tag
    //        if (interactable.CompareTag("CPU"))
    //        {
    //            Debug.Log("tag check");

    //            interactable.gameObject.layer = 8;
    //        }
    //    }
    //    else if ()
    //    {

    //    }
    //}

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        XRSocketInteractor socket = gameObject.GetComponent<XRSocketInteractor>();

        // check socket tag
        if (socket.CompareTag("SocketMotherboard"))
        {
            Debug.Log("tag check1");
            Debug.Log(interactable.name);

            // check object tag
            if (args.interactorObject is XRGrabInteractable)
            {
                Debug.Log("tag check2");
                interactable.gameObject.layer = 8;
            }
        }

        base.OnSelectEntered(args);
    }
}
