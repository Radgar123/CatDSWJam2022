using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class QuickRestart : MonoBehaviour
{

    [SerializeField] private InputActionReference create;
    // Start is called before the first frame update
    void Start()
    {
        create.action.performed += OnCreate;
    }


    private void OnCreate(InputAction.CallbackContext obj)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void OnDisable() {
        create.action.performed -= OnCreate;
    }
}
