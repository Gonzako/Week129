using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidingBox : MonoBehaviour
{
	AudioSource audiosource; 
	public AudioClip[] boxVelocity; 

    void Start()
    {
		audiosource = GetComponent<AudioSource>(); 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	void OnCollisionEnter(Collision collision)
	{

		if (collision.relativeVelocity.magnitude < 10)
		{
			audiosource.clip = boxVelocity[0]; 
			audiosource.Play(); 
		}

		else if (collision.relativeVelocity.magnitude > 20 && collision.relativeVelocity.magnitude < 30)
		{
			audiosource.clip = boxVelocity[1]; 
			audiosource.Play(); 
		}

		else if (collision.relativeVelocity.magnitude > 30 && collision.relativeVelocity.magnitude < 100)
		{
			audiosource.clip = boxVelocity[2]; 
			audiosource.Play(); 
		}
	
	}

}
