using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;

//brackeys tutorial on sound managers: https://www.youtube.com/watch?v=6OT43pvUyfY

public class audioManage : MonoBehaviour {

    public Sound[] sounds;
    public static audioManage instance;        //static reference to the current audio manager we have in our scene. to make sure we only have one instance

	// Use this for initialization
	void Awake () {                         //similar to start method but it's done right before

        if (instance == null)               //if we dont have an audio manager in our scene
        {
            instance = this;                    //set instance to this object
        }
        else
        {
            Destroy(gameObject);
            return; 
        } 

        DontDestroyOnLoad(gameObject);      //makes audio manager persist through different scenes 

		foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop; 
        }
	}

    void Start()
    {
        Play("mangroveForest");
    }

    public void Play(string name)   {               //can be called outside of the class           

        Sound s = Array.Find(sounds, sound => sound.name == name);      //find the sound where sound.name is = to the name
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + "not found!"); 
            return;
        }
        s.source.Play(); 

    }
}
