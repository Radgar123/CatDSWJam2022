using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    
    public bool collectedTreasure, gameOver;
    public Doors doors;
    // Start is called before the first frame update
    void Awake()
    {
        doors = GameObject.FindGameObjectWithTag("Doors").GetComponent<Doors>();

        if (Instance == null)
        {
           
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            
            Destroy(gameObject);
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        if(doors == null)
        {
            doors = GameObject.FindGameObjectWithTag("Doors").GetComponent<Doors>();
        }
   
    }

    public void OpenDoors()
    {
        doors.rb.isKinematic = false;
        doors.mesh.material = doors.green;
        doors.pointLight.color = doors.mesh.material.color;
        
    }
    public void NextLevel()
    {
        collectedTreasure = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       
    }
   
}
