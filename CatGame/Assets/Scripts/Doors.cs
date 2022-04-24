using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    [SerializeField] Material green;

    bool hasChangedToOpen = false;

    void Awake()
    {
        GameManager.PlayerEatEvent += ChangeToOpen;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && hasChangedToOpen)
        {
            GameManager.Instance.PlayerAtDoors();
        }   
    }

    public void ChangeToOpen()
    {
        GetComponentInChildren<Rigidbody>().isKinematic = false;
        GetComponentInChildren<MeshRenderer>().material = green;
        GetComponentInChildren<Light>().color = GetComponentInChildren<MeshRenderer>().material.color;

        hasChangedToOpen = true;
    }

    private void OnDestroy() {
        GameManager.PlayerEatEvent -= ChangeToOpen;
    }
}
