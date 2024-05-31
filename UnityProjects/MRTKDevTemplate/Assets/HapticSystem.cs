using Bhaptics.SDK2;
using MixedReality.Toolkit.UX;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HapticSystem : MonoBehaviour
{
    public float angleX = 0;
    public float offsetY = 0;

    public void SetAngleX(SliderEventData v)
    {
        angleX = v.NewValue;
    }

    public void SetOffestY(SliderEventData v)
    {
        offsetY = v.NewValue;
    }

    public void PlayHaptic(string eventName)
    {
        BhapticsLibrary.Play(eventName);
    }

    public void PlayHapticWithOption(string eventName)
    {
        BhapticsLibrary.PlayParam(eventName, 1, 1, angleX, offsetY);
    }
}
