using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidingBox : MonoBehaviour
{
	AudioSource audiosource; 
    void Start()
    {
		audiosource = GetComponent<AudioSource> (); 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	void OnCollisionEnter(Collision collision)
	{
		audiosource.Play (); 
	
	}

}
