using UnityEngine;
using FMOD.Studio;
using FMODUnity;

[CreateAssetMenu(fileName = "InteractiblesAudio", menuName = "Scriptable Objects/InteractiblesAudio")]
public class InteractiblesAudio : ScriptableObject
{
    // Declaring event references to specific event
    [SerializeField] private EventReference pickupHealthAudio, boxDestroyAudio,switchAudio,doorAudio, pressurePadAudio;

    // Method to play health pickup sound, no 3d positioning
    public void PickupHealthPlay()
    {
        RuntimeManager.PlayOneShot(pickupHealthAudio);
    }
// plays sound in 3d by getting the transform
    public void BoxDestroyPlay(Transform objectTransform)
    {
        // references obj transform pos
        RuntimeManager.PlayOneShot(boxDestroyAudio, objectTransform.position);
    }
// plays sound in 3d by getting the transform
    public void PressurePadPlay(Transform objectTransform)
    {
        // references obj transform pos
        RuntimeManager.PlayOneShot(pressurePadAudio, objectTransform.position);
    }
// plays sound in 3d by getting the transform
    public void SwitchAudioPlay(Transform objectTransform)
    {
        // references obj transform pos 
        RuntimeManager.PlayOneShot(switchAudio, objectTransform.position);
    }
}
