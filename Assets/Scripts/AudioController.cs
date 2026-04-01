using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioClip jumpSound;
    public AudioClip crashSound;

    private AudioSource playerAudio;

    private void Start()
    {
        playerAudio = GetComponent<AudioSource>();
    }

    public void PlayJumpSound()
    {
        playerAudio.PlayOneShot(jumpSound, 1.0f);
    }

    public void PlayCrashSound()
    {
        playerAudio.PlayOneShot(crashSound, 1.0f);
    }
}
