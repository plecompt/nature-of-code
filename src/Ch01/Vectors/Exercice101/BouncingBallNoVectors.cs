using Microsoft.Xna.Framework;

namespace NatureOfCode.Exercice101;

internal class BouncingBallNoVectors : Sketch
{
    private float x = 100;
    private float y = 100;
    private float xspeed = 2.5f;
    private float yspeed = 2f;

    protected override void ExecuteUpdate(GameTime gameTime)
    {
        x += xspeed;
        y += yspeed;

        if (x is > Width or < 0)
        {
            xspeed *= -1;
        }
        if (y is > Height or < 0)
        {
            yspeed *= -1;
        }
    }

    protected override void ExecuteDraw(GameTime gameTime)
    {
        SpriteBall.Draw(x, y);
    }
}
