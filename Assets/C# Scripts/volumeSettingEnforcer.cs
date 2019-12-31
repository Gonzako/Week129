/*
 *
 * Copyright (c) Gonzako
 * Gonzako123@gmail.com
 *
 */
 
using UnityEngine;
using ScriptableObjectArchitecture;

[RequireComponent(typeof(AudioSource))]
public class volumeSettingEnforcer : MonoBehaviour
{
    #region Public Fields
    #endregion

    #region Private Fields
    [SerializeField]
    IntVariable soundClass, masterVolume;

    [SerializeField]
    AudioSource adcs;

    float defaultVolume;
    #endregion

    #region Public Methods
    #endregion

    #region Private Methods
    private void SetVolume()
    {
        adcs.volume = defaultVolume * masterVolume.Value * soundClass.Value;
    }
    #endregion


    #if true
    #region Unity API

    void Awake()
    {
        if(adcs == null)adcs = GetComponent<AudioSource>();
        defaultVolume = adcs.volume;
        InvokeRepeating("SetVolume", 0f, 2f);
    }
 


    #endregion
    #endif
 
}