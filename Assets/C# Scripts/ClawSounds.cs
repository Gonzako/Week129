using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource), typeof(AudioLowPassFilter), typeof(HingeJoint))]
public class ClawSounds : MonoBehaviour
{
    public AudioClip[] adcs; 
	HingeJoint claw; 
	AudioSource[] audiosource;
	AudioLowPassFilter filter;
    [SerializeField]
    float bottomRange = -500, topRange = 500;
    [SerializeField]
    int cutoffFrec = 9720; 

    void Start()
    {
		claw = GetComponent<HingeJoint> (); 
		audiosource = GetComponents<AudioSource> ();
		filter = GetComponent<AudioLowPassFilter> (); 

		filter.cutoffFrequency = cutoffFrec;
        for (int i = 0; i < audiosource.Length; i++)
        {
            var j = i;
            if(i > adcs.Length)
            {
                j = i % adcs.Length;
            }
            audiosource[i].clip = adcs[j];
        }
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
			foreach(AudioSource n in audiosource)
            {
                n.pitch = pitchFinder();
                n.Play();
            }
		}
	}

	float pitchFinder()
	{
        return Random.Range(1.0f, 2.0f); 
	}
}
