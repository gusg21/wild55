using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    public Animator Animator;
    public string IdleAnimationState;
    public string BlinkAnimationState;

    private PlayerState _playerState = PlayerState.IDLE;

    // Start is called before the first frame update
    void Start()
    {
        Animator.Play(IdleAnimationState);

        StartCoroutine(Blink());
    }

    public void SetPlayerState(PlayerState state) => _playerState = state;

    IEnumerator Blink()
    {
        while (isActiveAndEnabled)
        {
            yield return new WaitForSeconds(Random.Range(10f, 15f));
            Animator.Play(BlinkAnimationState);
        }
    }

    // Update is called once per frame
    void Update() { }
}