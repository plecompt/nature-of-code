using Microsoft.Xna.Framework;
using MonoGame;

namespace NatureOfCode.Exercice103;

internal class VectorSubtraction : Sketch
{
    private readonly Vector2 _center = new(Width / 2, Height / 2);
    private Vector2 _mouse;

    public VectorSubtraction()
    {
        ClearColor = new Color(51, 51, 51);
    }

    protected override void ExecuteUpdate(GameTime gameTime)
    {
        _mouse = MousePosition;
    }

    protected override void ExecuteDraw(GameTime gameTime)
    {
        _spriteBatch.DrawLine(_center, _mouse, Color.White, 2f);
    }
}
