﻿/*
 *
 * Copyright (c) Gonzako
 * Gonzako123@gmail.com
 *
 */

using System;
using UnityEngine;
 
public class enableMotorWhileHold : MonoBehaviour
{
    #region Public Fields
    #endregion

    #region Private Fields
    private HingeJoint hj;
    #endregion

    #region Public Methods
    public event Action onMotorStart;
    public event Action onMotorEnd;
    #endregion

    #region Private Methods
    #endregion


    #if true
    #region Unity API

    void Start()
    {
        hj = GetComponent<HingeJoint>();
    }
 
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            onMotorStart?.Invoke();
            hj.useMotor = true;
        } else if (Input.GetButtonUp("Fire1") || (!Input.GetButton("Fire1") && hj.useMotor))
        {
            onMotorEnd?.Invoke();
            hj.useMotor = false;
        }
        
    }

    #endregion
    #endif
 
}