using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource), typeof(AudioLowPassFilter), typeof(HingeJoint))]
public class ClawSound : MonoBehaviour
{
	HingeJoint claw; 
	AudioSource audiosource;
	AudioLowPassFilter filter;
    [SerializeField]
    float bottomRange = -500, topRange = 500;
    [SerializeField]
    int cutoffFrec = 9720; 

    void Start()
    {
		claw = GetComponent<HingeJoint> (); 
		audiosource = GetComponent<AudioSource> ();
		filter = GetComponent<AudioLowPassFilter> (); 

		filter.cutoffFrequency = cutoffFrec; 
        
    }

    // Update is called once per frame
    void Update()
    {
		velocityCheck(); 
    }

	void velocityCheck()
	{
		if (claw.velocity < bottomRange || claw.velocity > topRange)
		{ 
			audiosource.pitch = pitchFinder();  
			audiosource.Play(); 
		}
	}

	float pitchFinder()
	{
        return Random.Range(1.0f, 2.0f); 
	}


}
