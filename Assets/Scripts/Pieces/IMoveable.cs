using System.Collections.Generic;

public interface IMoveable
{
    public void Move(Coordinate.Point coodinateToMove);
    public List<Coordinate.Point> GetAvailableSquares();
}
