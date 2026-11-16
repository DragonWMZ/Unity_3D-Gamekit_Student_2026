using UnityEngine;
using FMOD.Studio;
using FMODUnity;

[CreateAssetMenu(fileName = "InteractiblesAudio", menuName = "Scriptable Objects/InteractiblesAudio")]
public class InteractiblesAudio : ScriptableObject
{
    // Declaring event references to specific event
    [SerializeField] private EventReference pickupHealthAudio, boxDestroyAudio,switchAudio,doorAudio;

    // Method to play health pickup sound, no 3d positioning
    public void PickupHealthPlay()
    {
        RuntimeManager.PlayOneShot(pickupHealthAudio);
    }
}
