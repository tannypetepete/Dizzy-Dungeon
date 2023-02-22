using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Events/String Event Channel")]
public class StringEventChannelSO : SerializableScriptableObject
{
    public UnityAction<string> OnEventRaised;

    public void RaiseEvent(string value)
    {
        if (OnEventRaised != null)
            OnEventRaised.Invoke(value);
    }
}
