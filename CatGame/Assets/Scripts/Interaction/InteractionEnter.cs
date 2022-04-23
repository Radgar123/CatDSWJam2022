using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionEnter : MonoBehaviour
{
    public bool isUse;

    private void Start()
    {
        isUse = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        isUse = true;
    }

    private void OnTriggerExit(Collider other)
    {
        isUse = false;
    }
}
