using UnityEngine;
using System.Collections.Generic;
using Unity.Collections;
public class Knight : MonoBehaviour, IMoveable
{
    public List<Coordinate.Point> GetAvailableSquares() {
        List<Coordinate.Point> listToReturn = new List<Coordinate.Point>();
        Coordinate.Point knightCoordinate = gameObject.GetComponent<Coordinate>().GetCoordinates();
        if (knightCoordinate.x - 2 >= 0 && knightCoordinate.y - 1 >= 0 && knightCoordinate.x - 2 <= 7 && knightCoordinate.y - 1 <= 7) {
            listToReturn.Add(new Coordinate.Point{x=knightCoordinate.x - 2, y=knightCoordinate.y - 1});
        }
        if (knightCoordinate.x - 2 >= 0 && knightCoordinate.y + 1 >= 0 && knightCoordinate.x - 2 <= 7 && knightCoordinate.y + 1 <= 7) {
            listToReturn.Add(new Coordinate.Point{x=knightCoordinate.x - 2, y=knightCoordinate.y + 1});
        }
        if (knightCoordinate.x - 1 >= 0 && knightCoordinate.y - 2 >= 0 && knightCoordinate.x - 1 <= 7 && knightCoordinate.y - 2 <= 7) {
            listToReturn.Add(new Coordinate.Point{x=knightCoordinate.x - 1, y=knightCoordinate.y - 2});
        }
        if (knightCoordinate.x - 1 >= 0 && knightCoordinate.y + 2 >= 0 && knightCoordinate.x - 1 <= 7 && knightCoordinate.y + 2 <= 7) {
            listToReturn.Add(new Coordinate.Point{x=knightCoordinate.x - 1, y=knightCoordinate.y + 2});
        }
        if (knightCoordinate.x + 1 >= 0 && knightCoordinate.y - 2 >= 0 && knightCoordinate.x + 1 <= 7 && knightCoordinate.y - 2 <= 7) {
            listToReturn.Add(new Coordinate.Point{x=knightCoordinate.x + 1, y=knightCoordinate.y - 2});
        }
        if (knightCoordinate.x + 1 >= 0 && knightCoordinate.y + 2 >= 0 && knightCoordinate.x + 1 <= 7 && knightCoordinate.y + 2 <= 7) {
            listToReturn.Add(new Coordinate.Point{x=knightCoordinate.x + 1, y=knightCoordinate.y + 2});
        }
        if (knightCoordinate.x + 2 >= 0 && knightCoordinate.y - 1 >= 0 && knightCoordinate.x + 2 <= 7 && knightCoordinate.y - 1 <= 7) {
            listToReturn.Add(new Coordinate.Point{x=knightCoordinate.x + 2, y=knightCoordinate.y - 1});
        }
        if (knightCoordinate.x + 2 >= 0 && knightCoordinate.y + 1 >= 0 && knightCoordinate.x + 2 <= 7 && knightCoordinate.y + 1 <= 7) {
            listToReturn.Add(new Coordinate.Point{x=knightCoordinate.x + 2, y=knightCoordinate.y + 1});
        }
        return listToReturn;
    }
}