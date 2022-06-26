using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class UIManagerScript : MonoBehaviour
{
    [Header("Scriptable Objects")]
    public UIEventsSO uiEventsSO;

    [Header("Components")]
    [SerializeField] private GameObject PauseUIObject;
    [SerializeField] private GameObject GameplayUIObject;
    [SerializeField] private GameObject WinUIObject;
    [SerializeField] private GameObject LoseUIObject;
    [SerializeField] private Text ScoreText;

    [HideInInspector]
    public UnityEvent EnablePauseMenuUIEvent, DisablePauseMenuUIEvent, 
                      EnableGameplayUIEvent, DisableGameplayUIEvent, 
                      EnableWinUIEvent, EnableLoseUIEvent, 
                      UpdateScoreUI_INTEvent, UpdateScoreUI_FLOATEvent, UpdateAndRoundScoreUIEvent;
    
    #region UNITY METHODS
    void OnEnable()
    {
        //subscribe to the events
        uiEventsSO.EnablePauseMenuUIEvent.AddListener(EnablePauseMenuUIMethod);
        uiEventsSO.DisablePauseMenuUIEvent.AddListener(DisablePauseMenuUIMethod);
        uiEventsSO.EnableGameplayUIEvent.AddListener(EnableGameplayUIMethod);
        uiEventsSO.DisableGameplayUIEvent.AddListener(DisableGameplayUIMethod);
        uiEventsSO.EnableWinUIEvent.AddListener(EnableWinUIMethod);
        uiEventsSO.EnableLoseUIEvent.AddListener(EnableLoseUIMethod);
        uiEventsSO.DisableOnlyWinUIEvent.AddListener(DisableOnlyWinUIMethod);
        uiEventsSO.DisableOnlyLoseUIEvent.AddListener(DisableOnlyLoseUIMethod);
        
        uiEventsSO.UpdateScoreUI_INTEvent.AddListener(UpdateScoreUIMethod);
        uiEventsSO.UpdateScoreUI_FLOATEvent.AddListener(UpdateScoreUIMethod);
        uiEventsSO.UpdateAndRoundScoreUIEvent.AddListener(UpdateAndRoundScoreUIMethod);
    }
    
    void OnDisable()
    {
        //remove every listener which subscribed on enable method
        uiEventsSO.EnablePauseMenuUIEvent.RemoveAllListeners();
        uiEventsSO.DisablePauseMenuUIEvent.RemoveAllListeners();
        uiEventsSO.EnableGameplayUIEvent.RemoveAllListeners();
        uiEventsSO.DisableGameplayUIEvent.RemoveAllListeners();
        uiEventsSO.EnableWinUIEvent.RemoveAllListeners();
        uiEventsSO.EnableLoseUIEvent.RemoveAllListeners();
        uiEventsSO.DisableOnlyWinUIEvent.RemoveAllListeners();
        uiEventsSO.DisableOnlyLoseUIEvent.RemoveAllListeners();

        uiEventsSO.UpdateScoreUI_INTEvent.RemoveAllListeners();
        uiEventsSO.UpdateScoreUI_FLOATEvent.RemoveAllListeners();
        uiEventsSO.UpdateAndRoundScoreUIEvent.RemoveAllListeners();
    }
    #endregion
    
    #region READY TO USE UI CALLBACK METHODS
    //PAUSE_MENU
    public void EnablePauseMenuUIMethod(){PauseUIObject.SetActive(true);}
    public void DisablePauseMenuUIMethod(){PauseUIObject.SetActive(false);}
    
    //GAMEPLAY_UI
    public void EnableGameplayUIMethod(){GameplayUIObject.SetActive(true);}
    public void DisableGameplayUIMethod(){GameplayUIObject.SetActive(false);}
    
    //WIN_UI
    public void EnableWinUIMethod(){WinUIObject.SetActive(true);
    LoseUIObject.SetActive(false);}
    public void EnableLoseUIMethod(){WinUIObject.SetActive(false);
    LoseUIObject.SetActive(true);}

    //UPDATE_SCORE
    public void UpdateScoreUIMethod(int score, string _scoreText){ScoreText.text = _scoreText + score.ToString();}
    public void UpdateScoreUIMethod(float score, string _scoreText){ScoreText.text = _scoreText + score.ToString();}
    public void UpdateAndRoundScoreUIMethod(float score, string _scoreText) {ScoreText.text = _scoreText + ((byte)Mathf.Round(score)).ToString();}
    public void DisableOnlyLoseUIMethod(){LoseUIObject.SetActive(false);}
    public void DisableOnlyWinUIMethod(){WinUIObject.SetActive(false);}
    #endregion   
}
