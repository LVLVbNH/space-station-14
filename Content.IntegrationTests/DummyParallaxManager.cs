using System;
using Content.Client.Interfaces.Parallax;
using Robust.Client.Graphics;

namespace Content.IntegrationTests
{
    public sealed class DummyParallaxManager : IParallaxManager
    {
        public event Action<Texture> OnTextureLoaded
        {
            add
            {
            }
            remove
            {
            }
        }

        public Texture ParallaxTexture => null;

        public void LoadParallax()
        {
        }
    }
}
