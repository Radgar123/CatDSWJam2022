using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    [SerializeField] Material green;

    void Awake()
    {
        GameManager.PlayerEatEvent += ChangeToOpen;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.PlayerAtDoors();
        }   
    }

    public void ChangeToOpen()
    {
        GetComponent<Rigidbody>().isKinematic = false;
        GetComponent<MeshRenderer>().material = green;
        GetComponentInChildren<Light>().color = GetComponent<MeshRenderer>().material.color;
    }

    private void OnDestroy() {
        GameManager.PlayerEatEvent -= ChangeToOpen;
    }
}
