using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindPrefab : MonoBehaviour
{
    [Header("Audio")]
    public AudioClip windSFX;       
    public float maxHearingDistance = 15f;
    public float maxVolume = 1f;           

    private void Update()
    {
        PlayDistanceBasedSFX();
    }

    private void PlayDistanceBasedSFX()
    {
        if (AudioManager.Instance == null || windSFX == null)
            return;

        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player == null)
            return;

        float distance = Vector3.Distance(transform.position, player.transform.position);

        if (distance > maxHearingDistance)
            return; 

        float volume = Mathf.Lerp(maxVolume, 0f, distance / maxHearingDistance);

        if (!AudioManager.Instance.sfxSource.isPlaying || AudioManager.Instance.sfxSource.clip != windSFX)
        {
            AudioManager.Instance.sfxSource.clip = windSFX;
            AudioManager.Instance.sfxSource.loop = true;
            AudioManager.Instance.sfxSource.Play();
        }

        AudioManager.Instance.sfxSource.volume = volume;
    }
}
