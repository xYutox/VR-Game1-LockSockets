using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TEST : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Cube")
        {
            Debug.Log("Entered");
            Debug.Log(other.gameObject.GetComponent<XRBaseInteractable>());
            Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
            rb.constraints = RigidbodyConstraints.FreezeAll;
            other.gameObject.GetComponent<XRBaseInteractable>().enabled = false;
            other.gameObject.transform.rotation = Quaternion.Euler(0,0,0);
            other.transform.position = this.transform.position;
        }
    }
}
