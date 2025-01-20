using Microsoft.Xna.Framework;
using MonoGame;

namespace NatureOfCode.Exercice105;
internal class VectorMagnitude : Sketch
{
    private readonly Vector2 _center = new(Width / 2, Height / 2);
    private Vector2 _mouse;
    private int _magnitude;

    public VectorMagnitude()
    {
        ClearColor = new Color(51, 51, 51);
    }

    protected override void ExecuteUpdate(GameTime gameTime)
    {
        _mouse = MousePosition;
        _magnitude = (int)_mouse.Length();
    }

    protected override void ExecuteDraw(GameTime gameTime)
    {
        _spriteBatch.DrawRectangle(new Rectangle(0, 0, _magnitude, 5), Color.White, 5f);  // fill
        _spriteBatch.DrawRectangle(new Rectangle(0, 0, _magnitude, 10), Color.Black, 2f); // stroke
        _spriteBatch.DrawLine(_center, _mouse, Color.White, 2f);
    }
}
