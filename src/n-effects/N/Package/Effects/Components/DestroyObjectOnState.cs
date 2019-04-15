using N.Package.Effects.Infrastructure;
using N.Package.Optional;
using UnityEngine;

namespace N.Package.Effects.Components
{
    public class DestroyObjectOnState : OnAnimationState
    {
        protected override void Execute(GameObject gameObject)
        {
            EffectService.FindRootInHierarchyFor(gameObject).With(Destroy);
        }
    }
}