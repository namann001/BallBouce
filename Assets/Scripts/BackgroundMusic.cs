using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
 AudioSource m_MyAudioSource;

void Start()
{
	m_MyAudioSource = GetComponent<AudioSource>();
	m_MyAudioSource.Play();
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
