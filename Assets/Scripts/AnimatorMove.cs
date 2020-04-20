using UnityEngine;

public sealed class AnimatorMove : MonoBehaviour
{
    private Animator _animator;

    private static readonly int _animatorRunningSpeed = Animator.StringToHash("RunningSpeed");
    private static readonly int _animatorJumpTrigger = Animator.StringToHash("Jump");

    private void Start()
    {
        _animator = GetComponentInChildren<Animator>();
    }

    public void Move(float value)
    {
        _animator.SetFloat(_animatorRunningSpeed, value);
    }

    public void Jump()
    {            
        _animator.SetTrigger(_animatorJumpTrigger);

    }
}