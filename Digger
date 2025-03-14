using System;
using Avalonia.Input;
using Digger.Architecture;

namespace Digger;

//Напишите здесь классы Player, Terrain и другие.

public class Terrain : ICreature
{
    public string GetImageFileName()
    {
        return "Terrain.png";
    }

    public CreatureCommand Act(int x, int y)
    {
        return new CreatureCommand();
    }

    public bool DeadInConflict(ICreature conflictedObject)
    {
        return true;
    }

    public int GetDrawingPriority()
    {
        return 5;
    }
}

public class Player : ICreature
{
    public CreatureCommand Act(int x, int y)
    {
        var delta = CalculateDelta(Game.KeyPressed, x, y);

        return new CreatureCommand()
        {
            DeltaX = delta.Item1,
            DeltaY = delta.Item2
        };
    }

    private Tuple<int, int> CalculateDelta(
        Key key, int x, int y)
    {
        var dX = 0;
        var dY = 0;

        if (key == Key.Up || key == Key.W)
            dY--;
        if (key == Key.Down || key == Key.S)
            dY++;
        if (key == Key.Right || key == Key.D)
            dX++;
        if (key == Key.Left || key == Key.A)
            dX--;
        if (x + dX >= Game.MapWidth
            || x + dX < 0)
            dX = 0;
        if (y + dY >= Game.MapWidth
            || y + dY < 0)
            dY = 0;

        if (Game.Map[x+dX, y+dY] is Sack)
        {
            dX = 0;
            dY = 0;
        }
        return Tuple.Create(dX, dY);
    }
    public bool DeadInConflict(ICreature conflictedObject)
    {
        return conflictedObject is not Terrain
            && conflictedObject is not Gold;
    }

    public int GetDrawingPriority()
    {
        return 1;
    }

    public string GetImageFileName()
    {
        return "Digger.pgn";
    }
}
public class Sack : ICreature
{
    public CreatureCommand Act(int x, int y)
    {
        throw new NotImplementedException();
    }

    public bool DeadInConflict(ICreature conflictedObject)
    {
        return false;
    }

    public int GetDrawingPriority()
    {
        return 3;
    }

    public string GetImageFileName()
    {
        return "Sack.png";
    }
}
public class Gold : ICreature
{
    public CreatureCommand Act(int x, int y)
    {
        return new CreatureCommand();
    }

    public bool DeadInConflict(ICreature conflictedObject)
    {
        return conflictedObject is Player;
    }

    public int GetDrawingPriority()
    {
        return 2;
    }

    public string GetImageFileName()
    {
        return "Gold.png";
    }
}
