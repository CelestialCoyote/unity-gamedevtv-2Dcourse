using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AudioPlayer : MonoBehaviour
{
    [Header("Shooting")]
    [SerializeField] AudioClip shootingClip;
    [SerializeField] [Range(0.0f, 1.0f)] float shootingVolume = 0.4f;

    [Header("Damage")]
    [SerializeField] AudioClip damageClip;
    [SerializeField] [Range(0.0f, 1.0f)] float damageVolume = 0.5f;


    public void PlayShootingClip()
    {
        PlayClip(shootingClip, shootingVolume);
    }

    public void PlayDamageClip()
    {
        PlayClip(damageClip, damageVolume);
    }

    private void PlayClip(AudioClip clip, float volume)
    {
        if (clip != null)
        {
            Vector3 cameraPosition = Camera.main.transform.position;
            AudioSource.PlayClipAtPoint(clip, cameraPosition, volume);
        }
    }
}
