using Microsoft.Xna.Framework;

namespace NatureOfCode.Exercice102;

internal class BouncingBallVectors : Sketch
{
    private Vector2 position = new(100f);
    private Vector2 velocity = new(2.5f, 5f);

    protected override void ExecuteUpdate(GameTime gameTime)
    {
        position += velocity;

        if (position.X is > Width or < 0)
        {
            velocity.X *= -1;
        }
        if (position.Y is > Height or < 0)
        {
            velocity.Y *= -1;
        }
    }

    protected override void ExecuteDraw(GameTime gameTime)
    {
        SpriteBall.Draw(position);
    }
}