using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject onLoseUI;
    public GameObject onWinUI;
    public GameObject onStartUI;
    bool wasInvoked = false;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.PlayerAtDoorsEvent += DoorsOpen;
        
        GameManager.playerSpottedEvent += PlayerSpotted;

        Instantiate(onStartUI);
    }
    private void OnDisable() {
        GameManager.PlayerAtDoorsEvent -= DoorsOpen;
        
        GameManager.playerSpottedEvent -= PlayerSpotted;
    }
    void DoorsOpen(){
        if(wasInvoked)
            return;
        wasInvoked=true;
        Instantiate(onWinUI);
    }

        void PlayerSpotted(){
        if(wasInvoked)
            return;
        wasInvoked=true;
        Instantiate(onLoseUI);
    }
}
