using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour
{
    public string nextLevel;
    public AudioClip winFx;
    public AudioSource audioSource;

    void Start() 
    {
        audioSource = GetComponent<AudioSource>();
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {        
        if (collision.CompareTag("Player"))
        {
            StartCoroutine(WaitForSFX());
        }
    }

    IEnumerator WaitForSFX()
    {
        audioSource.clip = winFx;
        audioSource.Play();
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene(nextLevel);
    }
}