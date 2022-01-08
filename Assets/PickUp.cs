using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PickUp : MonoBehaviour
{
    public Transform theDest;

    private void OnMouseDown()
    {
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<BoxCollider>().enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = theDest.position;
        this.transform.parent = GameObject.Find("Destination").transform;
    }

    private void OnMouseUp()
    {


        GetComponent<Rigidbody>().isKinematic = false;
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Collider>().enabled = true;
        GetComponent<Rigidbody>().AddForce(GameObject.Find("Destination").transform.forward * 1000);
        
    }

}
