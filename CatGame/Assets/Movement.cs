using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class Movement : MonoBehaviour
{
    Vector2 movement;
    [SerializeField] private float moveSpeed = 10f;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move() 
    {
        Vector3 move = new Vector3(movement.x, 0, movement.y) * moveSpeed * Time.deltaTime;
        transform.Translate(move);
;    }

    private void OnMove(InputValue value)
    {
        //Debug.Log("Dziala");
        movement = value.Get<Vector2>();
    }
}
