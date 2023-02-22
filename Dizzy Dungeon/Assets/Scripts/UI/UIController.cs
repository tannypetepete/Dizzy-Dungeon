using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private bool initialShown = false;
    [SerializeField] private bool invert = false;

    [Header("Listening To")]
    [SerializeField] private BoolEventChannelSO ToggleEventChannel = default;

    private void Awake()
    {
        ToggleEventChannel.OnEventRaised += Toggle;
        gameObject.SetActive(initialShown);
    }

    private void OnDestroy()
    {
        ToggleEventChannel.OnEventRaised -= Toggle;
    }

    private void Toggle(bool show)
    {
        if (invert)
        {
            gameObject.SetActive(!show);
        }
        else
        {
            gameObject.SetActive(show);
        }
    }
}
