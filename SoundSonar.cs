using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSonar : MonoBehaviour
{
	public AudioSource PlaySound;

	public void PlaySoundInfo()
	{
		PlaySound.Play();
	}
}
