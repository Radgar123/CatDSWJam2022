using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treasure : MonoBehaviour
{
    public float RotateSpeed;

    void Update()
    {
        transform.Rotate(0, 1f * RotateSpeed * Time.deltaTime, 0f, Space.Self);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            transform.parent.gameObject.SetActive(false);
            GameManager.Instance.PlayerEat();
        }
    }
}
