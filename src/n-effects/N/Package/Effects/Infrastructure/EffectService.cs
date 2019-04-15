using N.Package.Optional;
using UnityEngine;

namespace N.Package.Effects.Infrastructure
{
    public class EffectService
    {
        /// <summary>
        /// Return the top most parent in the current chain of objects.
        /// </summary>
        public Option<GameObject> FindRootInHierarchyFor(GameObject target)
        {
            if (target == null) return Option.None<GameObject>();
            var marker = target.transform;
            while (marker.parent != null)
            {
                marker = marker.parent;
            }

            return Option.Some(marker.gameObject);
        }
    }
}