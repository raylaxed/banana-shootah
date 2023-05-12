using UnityEngine;
using System.Collections;

public class AnimationController : MonoBehaviour
{
    // Drag and drop the animation clip into this field in the inspector
    public AnimationClip animationClip;

    private Animation _animation;
    private float _animationLength;

    private void Start()
    {
        // Get the Animation component attached to this GameObject
        _animation = GetComponent<Animation>();

        // Add the animation clip to the Animation component
        _animation.AddClip(animationClip, animationClip.name);

        // Set the length of the animation clip
        _animationLength = animationClip.length;
    }

    public void PlayAnimation()
    {
        
        
            // Play the animation from the beginning
            _animation.Play(animationClip.name, PlayMode.StopAll);

            // Wait for the length of the animation clip
            StartCoroutine(WaitForAnimationEnd());
        
    }

    private IEnumerator WaitForAnimationEnd()
    {
        yield return new WaitForSeconds(_animationLength);

        // Stop the animation and reset it to frame 0
        _animation.Stop(animationClip.name);
        _animation[animationClip.name].normalizedTime = 0f;
    }
}
