using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SocketEvent : XRSocketInteractor
{
    private string socketTag;

    public void Start()
    {
        XRSocketInteractor socket = gameObject.GetComponent<XRSocketInteractor>();

        socketTag = socket.tag;

        Debug.Log("Socket Tag = " + socketTag);
    }

    protected override void OnSelectEntered(XRBaseInteractable interactable)
    {
        Debug.Log("Object Tag = " + interactable.tag);

        if(interactable.tag == socketTag)
        {
            Debug.Log("Right Object Placed in Socket");

            changeObjectLayer(interactable);
        }

        base.OnSelectEntered(interactable);
    }

    public void changeObjectLayer(XRBaseInteractable interactable)
    {
        interactable.gameObject.layer = 8;
    }
}
