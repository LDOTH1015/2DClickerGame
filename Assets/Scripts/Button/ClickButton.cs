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

    private void OnMouseDown()
    {
        GameManager.Instance.AddScore();
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = Camera.main.nearClipPlane;
        Vector2 clickPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        TriggerEffect(clickPosition);
    }

    private void OnAutoClick(Vector2 clickPosition)
    {
        GameManager.Instance.AddScore();
        TriggerEffect(clickPosition);
    }

    private void TriggerEffect(Vector2 clickPosition)
    {
        if (effectParticle != null)
        {
            Vector3 particlePosition = new Vector3(clickPosition.x, clickPosition.y, 0);
            ParticleSystem particle = Instantiate(effectParticle, particlePosition, Quaternion.identity);
            Destroy(particle.gameObject, 0.5f);
        }

        if (audioSource != null && crackSound != null)
        {
            audioSource.Play();
        }
    }
}
