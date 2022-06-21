using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timer;
    public float time;
    float msec;
    float sec;
    float min;
    void start()
    {
    StartCoroutine("StopWatch");
    }

    IEnumerator StopWatch()
    {
        while (true)
        {
        time += Time.deltaTime;
        msec = (int)((time - (int)time) * 100);
        sec = (int)(time % 60);
        min = (int)(time / 60 % 60);

        timer.text = string.Format("{0:00}:{1:00}:{2:00}",min,sec,msec);
       yield return null; 
        }
    }



}
