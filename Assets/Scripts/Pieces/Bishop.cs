using UnityEngine;
using System.Collections.Generic;

public class Bishop : MonoBehaviour, IMoveable
{
    private Board board;
    public List<Coordinate.Point> GetAvailableSquares() {
        List<Coordinate.Point> listToReturn = new List<Coordinate.Point>();
        Coordinate.Point pieceCoordinate = gameObject.GetComponent<Coordinate>().GetCoordinates();
        Coordinate.Point tmpCoordinate;
        board = GameObject.FindGameObjectWithTag("Board").GetComponent<Board>();
        bool canGo = true;
        tmpCoordinate = Coordinate.AddPoints(pieceCoordinate, new Coordinate.Point{x=1, y=1});
        while (canGo) {
            if (board.CanPlace(tmpCoordinate)) {
                listToReturn.Add(tmpCoordinate);
                tmpCoordinate = Coordinate.AddPoints(tmpCoordinate, new Coordinate.Point{x=1, y=1}); 
            } else {
                canGo = false;
            }
        }
        canGo = true;
        tmpCoordinate = Coordinate.AddPoints(pieceCoordinate, new Coordinate.Point{x=1, y=-1});
        while (canGo) {
            if (board.CanPlace(tmpCoordinate)) {
                listToReturn.Add(tmpCoordinate);
                tmpCoordinate = Coordinate.AddPoints(tmpCoordinate, new Coordinate.Point{x=1, y=-1}); 
            } else {
                canGo = false;
            }
        }
        canGo = true;
        tmpCoordinate = Coordinate.AddPoints(pieceCoordinate, new Coordinate.Point{x=-1, y=1});
        while (canGo) {
            if (board.CanPlace(tmpCoordinate)) {
                listToReturn.Add(tmpCoordinate);
                tmpCoordinate = Coordinate.AddPoints(tmpCoordinate, new Coordinate.Point{x=-1, y=1}); 
            } else {
                canGo = false;
            }
        }
        canGo = true;
        tmpCoordinate = Coordinate.AddPoints(pieceCoordinate, new Coordinate.Point{x=-1, y=-1});
        while (canGo) {
            if (board.CanPlace(tmpCoordinate)) {
                listToReturn.Add(tmpCoordinate);
                tmpCoordinate = Coordinate.AddPoints(tmpCoordinate, new Coordinate.Point{x=-1, y=-1}); 
            } else {
                canGo = false;
            }
        }
        return listToReturn;
    }
}
