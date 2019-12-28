/*
 *
 * Copyright (c) Gonzako
 * Gonzako123@gmail.com
 *
 */
 
using UnityEngine;
 
[RequireComponent(typeof(SpringJoint))]
public class mousePointToConnecterAnchor : MonoBehaviour
{
    #region Public Fields
    #endregion

    #region Private Fields
    SpringJoint springJoint;
    #endregion

    #region Public Methods
    #endregion

    #region Private Methods
    #endregion


    #if true
    #region Unity API

    void Start()
    {
        springJoint = GetComponent<SpringJoint>();

    }
 
    void FixedUpdate()
    {
        springJoint.connectedAnchor = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    #endregion
    #endif
 
}