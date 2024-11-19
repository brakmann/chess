using System.Collections.Generic;

public interface IMoveable
{
    public List<Coordinate.Point> GetAvailableSquares();
}
