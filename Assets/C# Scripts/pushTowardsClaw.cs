/*
 *
 * Copyright (c) Gonzako
 * Gonzako123@gmail.com
 *
 */
 
using UnityEngine;
 
public class pushTowardsClaw : MonoBehaviour
{
    #region Public Fields
    public Transform positionToPushTowards;
    public float forceToAdd = 2f;
    #endregion
 
    #region Private Fields
    #endregion

    #region Public Methods
    #endregion

    #region Private Methods
    #endregion


    #if true
    #region Unity API

    void Start()
    {
    }

    private void OnTriggerStay(Collider other)
    {
      
        Rigidbody otherRb = other.attachedRigidbody;
        Vector3 direction = positionToPushTowards.position - other.transform.position;
        direction = direction.normalized;
        otherRb.AddForce(direction * forceToAdd);
    }

    #endregion
#endif

}