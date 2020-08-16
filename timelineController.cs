using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class timelineController : MonoBehaviour
{
    bool playedOnce; 
    public List<PlayableDirector> playableDirectors;
    public List<TimelineAsset> timelines;


    void Start()
    {
        playedOnce = false;  
    }

    void FixedUpdate()
    {
        if (playedOnce == true)                                                     //if the timeline asset was played once
        {   
            transform.GetComponent<timelineController>().enabled = false;                   //then turn off the timeline Controller script 
        }
    }

    public void Play()
    {
        foreach (PlayableDirector playableDirector in playableDirectors)
        {
            playableDirector.Play();
        }
    }
    
    public void PlayFromTimelines(int index)
    {   
        TimelineAsset selectedAsset;

        if (timelines.Count <= index)
        {
            selectedAsset = timelines[timelines.Count - 1];
        }
        else
        {
            selectedAsset = timelines[index];
        }

        playableDirectors[0].Play(selectedAsset);
        playedOnce = true; 
    }
}