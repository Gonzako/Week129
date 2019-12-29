/*
 *
 * Copyright (c) Gonzako
 * Gonzako123@gmail.com
 *
 */
 
using UnityEngine;
 
public class gamePauserCode : MonoBehaviour
{
    #region Public Fields
    #endregion
 
    #region Private Fields
    #endregion

    #region Public Methods
    public void ResumeGame()
    {
        Time.timeScale = 1;
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }
    #endregion

    #region Private Methods
    #endregion


    #if false
    #region Unity API

    void Start()
    {
    }
 
    void FixedUpdate()
    {
    }

    #endregion
    #endif
 
}