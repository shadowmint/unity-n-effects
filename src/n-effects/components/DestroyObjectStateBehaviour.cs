using N.Package.Effects;
using UnityEngine;

namespace Assets.packages.helpers
{
  public class DestroyObjectStateBehaviour : StateMachineBehaviour
  {
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
      base.OnStateEnter(animator, stateInfo, layerIndex);
      var handler = animator.GetComponent<AnimationEventHandlerComponent>();
      if (handler != null)
      {
        handler.EventHandler.Trigger(new EffectCompletedEvent());
      }
      Object.Destroy(animator.gameObject);
    }
  }
}