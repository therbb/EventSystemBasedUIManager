using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestScript : MonoBehaviour
{
    public UIEventsSO uiEventsSO;
    void Start()
    {
        uiEventsSO.UpdateAndRoundScoreUIEvent.Invoke(25.3f, "Score: ");
    }

    void Update()
    {
        //Press D to enable, C to disable pause screen UI
        if (Input.GetKeyDown(KeyCode.D))
            uiEventsSO.EnablePauseMenuUIEvent.Invoke();
        else if (Input.GetKeyDown(KeyCode.C))
            uiEventsSO.DisablePauseMenuUIEvent.Invoke();

        //Press F to enable, v to disable gameplay UI
        if (Input.GetKeyDown(KeyCode.F))
            uiEventsSO.EnableGameplayUIEvent.Invoke();
        else if (Input.GetKeyDown(KeyCode.V))
            uiEventsSO.DisableGameplayUIEvent.Invoke();

        //Press G to enable win UI, B to enable lose UI
        if (Input.GetKeyDown(KeyCode.G))
            uiEventsSO.EnableWinUIEvent.Invoke();
        else if (Input.GetKeyDown(KeyCode.B))
            uiEventsSO.EnableLoseUIEvent.Invoke();

        //press right arrow to go to next scene if exists, press left arrow to go previous scene if exists
        if (Input.GetKeyDown(KeyCode.RightArrow) && SceneManager.GetActiveScene().buildIndex < SceneManager.sceneCountInBuildSettings - 1)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && SceneManager.GetActiveScene().buildIndex > 0)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
