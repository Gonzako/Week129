/*
 *
 * Copyright (c) Gonzako
 * Gonzako123@gmail.com
 *
 */
 
using UnityEngine;
using System.Collections.Generic;
 
public class luggageSpawnerCode : MonoBehaviour
{
    #region Public Fields
    public List<Transform> objsToSpawn;
    #endregion

    #region Private Fields
    [SerializeField]
    float cooldownTime = 0.3f, randomMaxPushForce = 10;
    float cooldownTimer = 0;
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
 
    void Update()
    {
        if(cooldownTimer < Time.time)
        {
            var whatevs = Instantiate(objsToSpawn[Random.Range(0, objsToSpawn.Count)]);
            whatevs.position = transform.position;
            cooldownTimer = Time.time + cooldownTime;
            whatevs.GetComponent<Rigidbody>().AddForce((Random.insideUnitCircle * Random.Range(0, randomMaxPushForce))/Time.deltaTime);

        }
    }

    #endregion
    #endif
 
}