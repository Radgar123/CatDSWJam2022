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
        Invoke("OpenDoors", 5f);
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        collectedTreasure = false;
    }

    // Update is called once per frame
    void Update()
    {

   
    }

    public void OpenDoors()
    {
        doors.rb.isKinematic = false;
        doors.mesh.material = doors.green;
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
   
}
