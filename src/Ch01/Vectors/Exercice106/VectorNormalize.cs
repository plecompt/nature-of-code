using Microsoft.Xna.Framework;
using MonoGame;

namespace NatureOfCode.Exercice106;

internal class VectorNormalize : Sketch
{
    private readonly Vector2 _center = new(Width / 2, Height / 2);
    private Vector2 _mouse;

    public VectorNormalize()
    {
        ClearColor = new Color(51, 51, 51);
    }

    protected override void ExecuteUpdate(GameTime gameTime)
    {
        _mouse = MousePosition - _center;
        _mouse.Normalize();
        _mouse *= 150f;
        _mouse += _center;
    }

    protected override void ExecuteDraw(GameTime gameTime)
    {
        _spriteBatch.DrawLine(_center, _mouse, Color.White, 2f);

    }
}
