using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource Normal_bgm;
    public AudioSource Eating_effect;

    public AudioSource Intro_bgm;
    public AudioSource Ghost_death_bgm;
    public AudioSource HitTheWall;
    public AudioSource Pac_death_effect;
    public AudioSource Scared_bgm;
    
    // Start is called before the first frame update
    void Awake()
    {
        Intro_bgm.Play();
    }

    private void Start()
    {
        Invoke("IntroBgm", 6);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void IntroBgm()
    {
        Normal_bgm.Play();
    }
}
