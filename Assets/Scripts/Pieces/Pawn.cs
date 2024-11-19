using System.Collections.Generic;
using UnityEngine;
public class Pawn : MonoBehaviour, IMoveable
{
    public List<Coordinate.Point> GetAvailableSquares() {
        List<Coordinate.Point> listToReturn = new List<Coordinate.Point>();
        Coordinate.Point pawnCoordinate = gameObject.GetComponent<Coordinate>().GetCoordinates();
        if (pawnCoordinate.y < 7) {
            listToReturn.Add(new Coordinate.Point{x=pawnCoordinate.x, y=pawnCoordinate.y+1});
        }
        return listToReturn;
    }
}
