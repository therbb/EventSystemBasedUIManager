using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{
    void Awake()
    {
        //dont destroy on load this game object
        DontDestroyOnLoad(gameObject);
    }
}
