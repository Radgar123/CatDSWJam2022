using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseSpikesTrapp : MonoBehaviour
{
    [SerializeField] private InteractionEnter interactor;
    [SerializeField] private Animator spikesEjection;

    private void Update()
    {
        UseTrap();
    }

    private void UseTrap() 
    {
        if (interactor.isUse == true)
        {
            spikesEjection.SetBool("isUse", true);
        }
        else
            spikesEjection.SetBool("isUse", false);
    }
}
