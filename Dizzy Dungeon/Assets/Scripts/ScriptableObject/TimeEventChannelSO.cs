using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Events/Time Event Channel")]
public class TimeEventChannelSO : SerializableScriptableObject
{

    public UnityAction<int, int> OnEventRaised;

    public void RaiseEvent(int sec, int min)
    {
        if (OnEventRaised != null)
            OnEventRaised.Invoke(sec, min);
    }
}
