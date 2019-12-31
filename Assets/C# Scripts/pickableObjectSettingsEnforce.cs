/*
 *
 * Copyright (c) Gonzako
 * Gonzako123@gmail.com
 *
 */
 
using UnityEngine;
 
[RequireComponent(typeof(Rigidbody), typeof(Collider)), ExecuteInEditMode]
public class pickableObjectSettingsEnforce : MonoBehaviour
{
    #region Public Fields

    public float zOffset = 0;
    #endregion

    #region Private Fields
    Rigidbody rb;
    #endregion

    #region Public Methods
    #endregion

    #region Private Methods
    #endregion


    #if true

    #region Unity API

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        var constraints = new RigidbodyConstraints();
        constraints = RigidbodyConstraints.FreezePositionZ;

        rb.constraints = constraints;
        transform.position = (Vector2)transform.position;
    }
 
    void Update()
    {
        rb.useGravity = false;
        transform.position = (Vector3)((Vector2)transform.position) + Vector3.forward * zOffset;


    }

    #endregion
#endif

}