using Microsoft.Xna.Framework;

namespace NatureOfCode.Exercice107;

internal class Motion101 : Sketch
{
    private readonly Mover _mover = new(Width, Height);

    protected override void ExecuteUpdate(GameTime gameTime)
    {
        _mover.Update();
        _mover.CheckEdges();
    }

    protected override void ExecuteDraw(GameTime gameTime)
    {
        _mover.Display(SpriteBall);
    }
}
