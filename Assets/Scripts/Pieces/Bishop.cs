using UnityEngine;
using System.Collections.Generic;

public class Bishop : MonoBehaviour, IMoveable
{
    private Coordinate coordinate;
    public List<Coordinate.Point> GetAvailableSquares() {
        List<Coordinate.Point> listToReturn = new List<Coordinate.Point>();
        Coordinate.Point bishopCoordinate = gameObject.GetComponent<Coordinate>().GetCoordinates();   
        bool canGo = true;
        int i = bishopCoordinate.x + 1;
        int j = bishopCoordinate.y + 1;
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
        i = bishopCoordinate.x + 1;
        j = bishopCoordinate.y - 1;
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
        i = bishopCoordinate.x - 1;
        j = bishopCoordinate.y + 1;
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
        i = bishopCoordinate.x - 1;
        j = bishopCoordinate.y - 1;
        while (canGo) {
            if (i < 8 && i >= 0 && j < 8 && j >= 0) {
                listToReturn.Add(new Coordinate.Point{x=i, y=j});
                i--;
                j--;
            } else {
                canGo = false;
            }
        }
        Debug.Log(listToReturn);
        return listToReturn;
    }
}