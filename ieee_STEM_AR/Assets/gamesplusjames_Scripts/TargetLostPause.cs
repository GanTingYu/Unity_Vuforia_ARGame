using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetLostPause : MonoBehaviour
{
    public void TargetLostPauseVuforia()
    {
        Time.timeScale=0;
    }
}
