using UnityEditor;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    //싱글톤
    public static SoundManager instance; //싱글톤 변수

    AudioSource myAudio; //AudioSource 컴포넌트 변수로 담는다(AudioSource: 소리와 관련된 변수)


    public AudioClip soundBullet; //재생할 소리 변수
    public AudioClip soundDie; //죽는 사운드

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    void Start()
    {
        myAudio = GetComponent<AudioSource>(); //AudioSource 컴포넌트 가져오기
    }

    
    void Update()
    {
        
    }


    public void SoundDie()
    {
        myAudio.PlayOneShot(soundDie); //몬스터 죽는 소리
    }

    public void SoundBullet()
    {
        myAudio.PlayOneShot(soundBullet);
    }
}
