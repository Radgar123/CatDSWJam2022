using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public delegate void OnPlayerSpotted();
    public static event OnPlayerSpotted playerSpottedEvent;

    public delegate void OnPlayerEat();
    public static event OnPlayerEat PlayerEatEvent;

    public delegate void OnPlayerDoors();
    public static event OnPlayerDoors PlayerAtDoorsEvent;

    void Awake()
    {
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





    public void PlayerAtDoors()
    {
        PlayerAtDoorsEvent?.Invoke();
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void PlayerSpotted()
    {
        playerSpottedEvent?.Invoke();
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void PlayerEat()
    {
        PlayerEatEvent?.Invoke();
    }
   
}
