using UnityEngine;
using System.Collections.Generic;

public class Rook : MonoBehaviour, IMoveable
{
    public List<Coordinate.Point> GetAvailableSquares() {
        List<Coordinate.Point> listToReturn = new List<Coordinate.Point>();
        Coordinate.Point rookCoordinate = gameObject.GetComponent<Coordinate>().GetCoordinates();   
        bool canGo = true;
        int i = rookCoordinate.x + 1;
        int j = rookCoordinate.y;
        while (canGo) {
            if (i < 8 && i >= 0 && j < 8 && j >= 0) {
                listToReturn.Add(new Coordinate.Point{x=i, y=j});
                i++;
            } else {
                canGo = false;
            }
        }
        canGo = true;
        i = rookCoordinate.x - 1;
        j = rookCoordinate.y;
        while (canGo) {
            if (i < 8 && i >= 0 && j < 8 && j >= 0) {
                listToReturn.Add(new Coordinate.Point{x=i, y=j});
                i--;
            } else {
                canGo = false;
            }
        }
        canGo = true;
        i = rookCoordinate.x;
        j = rookCoordinate.y + 1;
        while (canGo) {
            if (i < 8 && i >= 0 && j < 8 && j >= 0) {
                listToReturn.Add(new Coordinate.Point{x=i, y=j});
                j++;
            } else {
                canGo = false;
            }
        }
        canGo = true;
        i = rookCoordinate.x;
        j = rookCoordinate.y - 1;
        while (canGo) {
            if (i < 8 && i >= 0 && j < 8 && j >= 0) {
                listToReturn.Add(new Coordinate.Point{x=i, y=j});
                j--;
            } else {
                canGo = false;
            }
        }
        return listToReturn;
    }
}
