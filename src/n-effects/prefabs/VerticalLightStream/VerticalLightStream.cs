using UnityEngine;
using System.Collections;

public class VerticalLightStream : StateMachineBehaviour
{
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);
        Object.Destroy(animator.gameObject);
    }
}