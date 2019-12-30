using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidingBox : MonoBehaviour
{
    [SerializeField]
    float collisionRestTime = 0.1f;
    float collisionRestCounter = 0;

	AudioSource audiosource;
    [SerializeField]
    int bottomRange = 10, topRange = 30;

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

        if (collisionRestCounter < Time.time)
        {
            if (collision.relativeVelocity.magnitude < bottomRange)
            {
                audiosource.clip = boxVelocity[0];
                audiosource.Play();
            }

            else if (collision.relativeVelocity.magnitude > bottomRange && collision.relativeVelocity.magnitude < topRange)
            {
                audiosource.clip = boxVelocity[1];
                audiosource.Play();
            }

            else if (collision.relativeVelocity.magnitude > topRange /*&& collision.relativeVelocity.magnitude < topRange*/)
            {
                audiosource.clip = boxVelocity[2];
                audiosource.Play();
            }

            collisionRestCounter = Time.time + collisionRestTime;
        }
	
	}

}
