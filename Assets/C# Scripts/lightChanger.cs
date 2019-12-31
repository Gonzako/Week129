/*
 *
 * Copyright (c) Gonzako
 * Gonzako123@gmail.com
 *
 */
 
using UnityEngine;
using UnityEngine.Rendering;

public class lightChanger : MonoBehaviour
{
    #region Public Fields
    [ColorUsage(true, true)]
    public Color emissionToChangeTo;
    public Color colorToChangeTo;
    #endregion
 
    #region Private Fields
    #endregion

    #region Public Methods
    public void ChangeColour()
    {
        var renderer = GetComponent<Renderer>();
        MaterialPropertyBlock mat = new MaterialPropertyBlock();
        mat.SetColor("_BaseColor", colorToChangeTo);
        mat.SetColor("_EmissionColor", emissionToChangeTo);
        renderer.SetPropertyBlock(mat);
    }
    #endregion

    #region Private Methods
    #endregion


    #if false
    #region Unity API

    void Start()
    {
        ChangeColour();
    }
 
    void FixedUpdate()
    {
    }

    #endregion
    #endif
 
}