using UnityEngine;
using System.Collections;
using N.Package.Core;

public class ButtonEffect : MonoBehaviour
{
    public GameObject Target;
    public Vector3 Scale;

    public void StarPulse()
    {
        Scene.Prefab("N.Package.Effects/StarPulse").Then((ep) =>
        {
            var instance = Scene.Spawn(ep);
            if (instance)
            {
                instance.Unwrap().gameObject.transform.position = Target.transform.position;
                instance.Unwrap().gameObject.transform.localScale = Scale;
            }
        });
    }
}