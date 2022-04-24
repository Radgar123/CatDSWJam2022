using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIEndButtons : MonoBehaviour
{
    public void NextLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void TryAgain(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void BackToMenu(){
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame(){

    }

    public void Credits(){
        SceneManager.LoadScene("Credits");
    }
}
