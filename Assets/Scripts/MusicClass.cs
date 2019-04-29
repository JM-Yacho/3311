using UnityEngine;

public class MusicClass : MonoBehaviour
{
    private static AudioSource _audioSource;
    private void Awake()
    {
        if(_audioSource != null)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(transform.gameObject);
            _audioSource = GetComponent<AudioSource>();
        }
    }

    public void PlayMusic()
    {
        if (_audioSource.isPlaying) return;
        _audioSource.Play();
    }

    public void StopMusic()
    {
        _audioSource.Stop();
    }
}