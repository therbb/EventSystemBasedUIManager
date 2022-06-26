using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "UIEventsSO", menuName = "UIManager/UIEventsSO")]
public class UIEventsSO : ScriptableObject
{
    [HideInInspector]
    public UnityEvent EnablePauseMenuUIEvent, DisablePauseMenuUIEvent, 
                      EnableGameplayUIEvent, DisableGameplayUIEvent, 
                      EnableWinUIEvent, EnableLoseUIEvent,
                      DisableOnlyWinUIEvent, DisableOnlyLoseUIEvent;
    
    [HideInInspector]
    public UnityEvent<int, string> UpdateScoreUI_INTEvent;
    [HideInInspector]
    public UnityEvent<float, string> UpdateScoreUI_FLOATEvent;
    [HideInInspector]
    public UnityEvent<float, string> UpdateAndRoundScoreUIEvent;
}
