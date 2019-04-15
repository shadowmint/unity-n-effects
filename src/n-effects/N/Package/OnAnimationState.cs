using UnityEngine;

namespace N.Package.Effects.Infrastructure
{
    public abstract class OnAnimationState : StateMachineBehaviour
    {
        protected readonly EffectService EffectService = new EffectService();

        public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            var gameObject = animator.gameObject;
            Execute(gameObject);
        }

        protected abstract void Execute(GameObject gameObject);
    }
}