using UnityEngine;
using System.Collections.Generic;

public class Queen : MonoBehaviour, IMoveable
{
    public List<Coordinate.Point> GetAvailableSquares() {
        List<Coordinate.Point> listToReturn = new List<Coordinate.Point>();
        Coordinate.Point queenCoordinate = gameObject.GetComponent<Coordinate>().GetCoordinates();   
        bool canGo = true;
        int i = queenCoordinate.x + 1;
        int j = queenCoordinate.y;
        while (canGo) {
            if (i < 8 && i >= 0 && j < 8 && j >= 0) {
                listToReturn.Add(new Coordinate.Point{x=i, y=j});
                i++;
            } else {
                canGo = false;
            }
        }
        canGo = true;
        i = queenCoordinate.x - 1;
        j = queenCoordinate.y;
        while (canGo) {
            if (i < 8 && i >= 0 && j < 8 && j >= 0) {
                listToReturn.Add(new Coordinate.Point{x=i, y=j});
                i--;
            } else {
                canGo = false;
            }
        }
        canGo = true;
        i = queenCoordinate.x;
        j = queenCoordinate.y + 1;
        while (canGo) {
            if (i < 8 && i >= 0 && j < 8 && j >= 0) {
                listToReturn.Add(new Coordinate.Point{x=i, y=j});
                j++;
            } else {
                canGo = false;
            }
        }
        canGo = true;
        i = queenCoordinate.x;
        j = queenCoordinate.y - 1;
        while (canGo) {
            if (i < 8 && i >= 0 && j < 8 && j >= 0) {
                listToReturn.Add(new Coordinate.Point{x=i, y=j});
                j--;
            } else {
                canGo = false;
            }
        }
        canGo = true;
        i = queenCoordinate.x + 1;
        j = queenCoordinate.y + 1;
        while (canGo) {
            if (i < 8 && i >= 0 && j < 8 && j >= 0) {
                listToReturn.Add(new Coordinate.Point{x=i, y=j});
                i++;
                j++;
            } else {
                canGo = false;
            }
        }
        canGo = true;
        i = queenCoordinate.x + 1;
        j = queenCoordinate.y - 1;
        while (canGo) {
            if (i < 8 && i >= 0 && j < 8 && j >= 0) {
                listToReturn.Add(new Coordinate.Point{x=i, y=j});
                i++;
                j--;
            } else {
                canGo = false;
            }
        }
        canGo = true;
        i = queenCoordinate.x - 1;
        j = queenCoordinate.y + 1;
        while (canGo) {
            if (i < 8 && i >= 0 && j < 8 && j >= 0) {
                listToReturn.Add(new Coordinate.Point{x=i, y=j});
                i--;
                j++;
            } else {
                canGo = false;
            }
        }
        canGo = true;
        i = queenCoordinate.x - 1;
        j = queenCoordinate.y - 1;
        while (canGo) {
            if (i < 8 && i >= 0 && j < 8 && j >= 0) {
                listToReturn.Add(new Coordinate.Point{x=i, y=j});
                i--;
                j--;
            } else {
                canGo = false;
            }
        }
        return listToReturn;
    }
}
