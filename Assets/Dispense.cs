using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dispense : MonoBehaviour
{
    public GameObject ball;
    public Transform ballSpawn;

    private void OnMouseDown()
    {
        Instantiate(ball, ballSpawn.position, ballSpawn.rotation);
    }
}
