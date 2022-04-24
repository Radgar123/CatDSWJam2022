using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyLiveObject : MonoBehaviour
{
   [SerializeField] private bool active;

    private void Start()
    {
        Invoke("TurnActive", 1f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (active)
        {
            if (other.transform.tag != "Pushable" && other.transform.tag != "Ground")
                Destroy(other.gameObject);
        }
      
    }

    private void TurnActive()
    {
        active = true;
    }
}
