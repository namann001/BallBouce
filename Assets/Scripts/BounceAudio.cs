using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceAudio : MonoBehaviour
{
 AudioSource m_MyAudioSource;

void Start()
{
	m_MyAudioSource = GetComponent<AudioSource>();
}

public void PlaySound()
{
	m_MyAudioSource.Play();
}
		
public void StopSound()
{
	m_MyAudioSource.Stop();
}
}
