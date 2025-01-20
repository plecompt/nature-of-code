using Microsoft.Xna.Framework;

namespace NatureOfCode.Exercice102;
internal class BouncingBallVectorsObject : Sketch
{
    private readonly Ball _ball = new(Width, Height);
    protected override void ExecuteUpdate(GameTime gameTime) => _ball.Update();
    protected override void ExecuteDraw(GameTime gameTime) => _ball.Draw(SpriteBall);
}

internal class Ball
{
    private Vector2 position = new(100f);
    private Vector2 velocity = new(2.5f, 5f);
    private readonly float _width;
    private readonly float _height;

    public Ball(float width, float height)
    {
        _width = width;
        _height = height;
    }

    public void Update()
    {
        position += velocity;

        if (position.X > _width || position.X < 0)
        {
            velocity.X *= -1;
        }
        if (position.Y > _height || position.Y < 0)
        {
            velocity.Y *= -1;
        }
    }

    public void Draw(SpriteBall spriteBall)
    {
        spriteBall.Draw(position);
    }
}