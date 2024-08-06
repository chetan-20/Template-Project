using System;
using UnityEngine;

public class SoundService : MonoBehaviour
{     
    [SerializeField] private AudioSource soundEffect;
    [SerializeField] private AudioSource soundMusic;
    [SerializeField] private bool IsMute = false;
    [SerializeField] private SoundType[] audioClips;
    
    private void Start()
    {
        PlayMusic();
    }
    public void PlayMusic()
    {
        if (IsMute)
        {
            soundMusic.Stop();
            return;
        }        
        else if(soundMusic != null)
        {
            soundMusic.Play();
        }
        {
            Debug.Log("Audio Not Assigned");
        }
    }    
    public void PlaySound(Sounds sound)
    {
        if (IsMute) return;        
        AudioClip clip = GetSoundClip(sound);
        if (clip != null)
        {
            soundEffect.PlayOneShot(clip);
        }
        else
        {
            Debug.Log("Audio Not Assigned");
        }
    }
    private AudioClip GetSoundClip(Sounds sound)
    {
        SoundType item = Array.Find(audioClips, i => i.soundtype == sound);
        if (item != null)
        {
            return item.soundclip;
        }
        else
        {
            return null;
        }
    }
    public void ToggleMute() 
    {   IsMute = !IsMute;
        if (IsMute) {GameService.Instance.PopUpService.ShowPopupMessage("Muted"); }
        else { GameService.Instance.PopUpService.ShowPopupMessage("Un-Muted"); }
    }
}
[Serializable]
public class SoundType
{
    public Sounds soundtype;
    public AudioClip soundclip;
}
public enum Sounds
{   
    ButtonClick    
}
