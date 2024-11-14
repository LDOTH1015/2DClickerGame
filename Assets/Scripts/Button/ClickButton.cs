using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickButton : MonoBehaviour
{
    public ParticleSystem effectParticle;
    public AudioClip crackSound;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
        audioSource.clip = crackSound;
    }
    void OnMouseDown()
    {
        GameManager.Instance.AddScore();
        if (effectParticle != null)
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = Camera.main.nearClipPlane;
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

            ParticleSystem particle = Instantiate(effectParticle, worldPosition, Quaternion.identity);

            Destroy(particle.gameObject, 0.5f);
        }
        if (audioSource != null && crackSound != null)
        {
            audioSource.Play();
        }
    }
}
