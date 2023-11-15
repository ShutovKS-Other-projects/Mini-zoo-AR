using UnityEngine;

public class FoxController : MonoBehaviour
{
    private const string IS_ATTACK_PAWS = "isAttackPaws";
    private const string IS_ATTACK_TAIL = "isAttackTail";
    private const string IS_FALLING = "isFalling";
    private const string IS_FALLING_LEFT = "isFallingLeft";
    private const string IS_IDLE = "isIdle";
    private const string IS_JUMPING = "isJumping";
    private const string IS_SIT = "isSit";
    private const string IS_WALKING = "isWalking";

    public Animator animator;

    public void SetAttackPaws()
    {
        SetAnimation(IS_ATTACK_PAWS);
    }

    public void SetAttackTail()
    {
        SetAnimation(IS_ATTACK_TAIL);
    }

    public void SetFalling()
    {
        SetAnimation(IS_FALLING);
    }

    public void SetFallingLeft()
    {
        SetAnimation(IS_FALLING_LEFT);
    }

    public void SetIdle()
    {
        SetAnimation(IS_IDLE);
    }

    public void SetJumping()
    {
        SetAnimation(IS_JUMPING);
    }

    public void SetSit()
    {
        SetAnimation(IS_SIT);
    }

    public void SetWalking()
    {
        SetAnimation(IS_WALKING);
    }

    private void SetAnimation(string animation)
    {
        ResetAnimation();
        animator.SetBool(animation, true);
    }

    private void ResetAnimation()
    {
        animator.SetBool(IS_ATTACK_PAWS, false);
        animator.SetBool(IS_ATTACK_TAIL, false);
        animator.SetBool(IS_FALLING, false);
        animator.SetBool(IS_FALLING_LEFT, false);
        animator.SetBool(IS_IDLE, false);
        animator.SetBool(IS_JUMPING, false);
        animator.SetBool(IS_SIT, false);
        animator.SetBool(IS_WALKING, false);
    }
}