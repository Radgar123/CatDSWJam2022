using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class Movement : MonoBehaviour
{
    public Vector2 movement;
    public Vector2 temp;

    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] GameObject GFX;
    //[SerializeField] AudioSource audioSource;
    //[SerializeField] AudioClip moveClip;

    [SerializeField] ParticleSystem moveParticle;

    private bool isPlay = false;

    private void Start()
    {
        //audioSource.clip = moveClip;
    }

    // Update is called once per frame  
    void Update()
    {
        Move();
    }

    private void Move() 
    {
        if (movement.x == 0 && movement.y == 0) 
        {
            //audioSource.Stop();
            isPlay = false;
            moveParticle.Simulate(0, false, true);
            moveParticle.Pause();
        }
        else if (!isPlay) 
        {
            isPlay = true;
            //audioSource.Play();
            moveParticle.Play();
        }

        Vector3 move = new Vector3(movement.x, 0, movement.y);
        transform.Translate(move.normalized * moveSpeed * Time.deltaTime);
        temp = movement;

        if(transform.position.y < -300)
            GameManager.Instance.PlayerSpotted();
    }

    private void OnMove(InputValue value)
    {
        //Debug.Log("Dziala");
        movement = value.Get<Vector2>();
        
        GFX.transform.LookAt(new Vector3((GFX.transform.position.x + movement.x), GFX.transform.position.y, (GFX.transform.position.z + movement.y)));

        //audioSource.PlayOneShot(moveClip);
    }
}
