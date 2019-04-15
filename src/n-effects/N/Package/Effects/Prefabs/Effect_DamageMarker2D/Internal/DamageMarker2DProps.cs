using UnityEngine;
using UnityEngine.UI;

namespace N.Package.Effects.Prefabs.Effect_DamageMarker2D.Internal
{
    public class DamageMarker2DProps : MonoBehaviour
    {
        public Font font;
        public Text text1;
        public Text text2;

        private void Start()
        {
            text1.font = font;
            text2.font = font;
        }
    }
}