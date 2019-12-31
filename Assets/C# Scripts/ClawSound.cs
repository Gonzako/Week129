using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawSound : MonoBehaviour
{
	HingeJoint claw; 
	AudioSource audiosource;
	AudioLowPassFilter filter; 


    void Start()
    {
		claw = GetComponent<HingeJoint> (); 
		audiosource = GetComponent<AudioSource> ();
		filter = GetComponent<AudioLowPassFilter> (); 

		filter.cutoffFrequency = 9720; 
        
    }

    // Update is called once per frame
    void Update()
    {
		velocityCheck(); 
    }

	void velocityCheck()
	{
		if (claw.velocity < -500 || claw.velocity > 500)
		{ 
			audiosource.pitch = pitchFinder();  
			audiosource.Play(); 
		}
	}

	float pitchFinder()
	{
		float randomNumber = Random.Range (1.0f, 2.0f); 
		return randomNumber; 
	}


}
