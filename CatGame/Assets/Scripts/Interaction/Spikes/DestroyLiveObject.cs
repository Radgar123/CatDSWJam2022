using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyLiveObject : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag != "Pushable")
            Destroy(other.gameObject);
    }
}
