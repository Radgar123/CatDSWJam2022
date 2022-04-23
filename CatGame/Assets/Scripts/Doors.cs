using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    public Rigidbody rb;
    public Material green;
    public MeshRenderer mesh;
    public Light pointLight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (GameManager.Instance.collectedTreasure == true)
            {
                GameManager.Instance.NextLevel();
            }
        }
        
    }
}
