using UnityEngine;
using N.Package.Events;

namespace Assets.packages.helpers
{
  public class AnimationEventHandlerComponent : MonoBehaviour
  {
    private readonly EventHandler _eventHandler = new EventHandler();

    public EventHandler EventHandler
    {
      get { return _eventHandler; }
    }
  }
}