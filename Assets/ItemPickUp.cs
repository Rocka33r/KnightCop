using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    public int index;

    public GameManager gm;

    private void OnMouseDown()
    {
        gm.checkObject(index);
        gm.gameObject.GetComponent<AudioSource>().Play();
        gameObject.SetActive(false);
    }
}
