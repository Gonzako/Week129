/*
 *
 * Copyright (c) Gonzako
 * Gonzako123@gmail.com
 *
 */
 
using UnityEngine;
 
public class onScore : MonoBehaviour
{
    #region Public Fields
    public lightChanger changer;
    #endregion

    #region Private Fields
    private AudioSource sound;

    #endregion

    #region Public Methods
    #endregion

    #region Private Methods
    #endregion


    #if true
    #region Unity API

    void Awake()
    {
        sound = GetComponent<AudioSource>();
    }
 
    void FixedUpdate()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        changer.ChangeColour();
        Destroy(other.attachedRigidbody.gameObject, 0.3f);
        other.attachedRigidbody.detectCollisions = false;
            sound.Play();
        changer.colorToChangeTo = Random.ColorHSV();
        changer.emissionToChangeTo = Random.ColorHSV();

    }
    #endregion
#endif

}