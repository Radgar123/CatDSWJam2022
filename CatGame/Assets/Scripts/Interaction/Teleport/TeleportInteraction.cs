using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportInteraction : MonoBehaviour
{
    [SerializeField] private Transform destination;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player" || other.transform.tag == "Pushable")
            other.transform.position = destination.position;
    }
}
