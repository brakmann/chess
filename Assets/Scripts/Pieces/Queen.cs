using UnityEngine;
using System.Collections.Generic;

public class Queen : MonoBehaviour, IMoveable
{
    private Board board;
    public List<Coordinate.Point> GetAvailableSquares() {
        List<Coordinate.Point> listToReturn = new List<Coordinate.Point>();
        Coordinate.Point pieceCoordinate = gameObject.GetComponent<Coordinate>().GetCoordinates();
        Coordinate.Point tmpCoordingate;
        board = GameObject.FindGameObjectWithTag("Board").GetComponent<Board>();
        bool canGo = true;
        tmpCoordingate = Coordinate.AddPoints(pieceCoordinate, new Coordinate.Point{x=1, y=0});
        while (canGo) {
            if (board.IsOnBoard(tmpCoordingate)) {
                listToReturn.Add(tmpCoordingate);
                tmpCoordingate = Coordinate.AddPoints(tmpCoordingate, new Coordinate.Point{x=1, y=0}); 
            } else {
                canGo = false;
            }
        }
        canGo = true;
        tmpCoordingate = Coordinate.AddPoints(pieceCoordinate, new Coordinate.Point{x=-1, y=0});
        while (canGo) {
            if (board.IsOnBoard(tmpCoordingate)) {
                listToReturn.Add(tmpCoordingate);
                tmpCoordingate = Coordinate.AddPoints(tmpCoordingate, new Coordinate.Point{x=-1, y=0}); 
            } else {
                canGo = false;
            }
        }
        canGo = true;
        tmpCoordingate = Coordinate.AddPoints(pieceCoordinate, new Coordinate.Point{x=0, y=1});
        while (canGo) {
            if (board.IsOnBoard(tmpCoordingate)) {
                listToReturn.Add(tmpCoordingate);
                tmpCoordingate = Coordinate.AddPoints(tmpCoordingate, new Coordinate.Point{x=0, y=1}); 
            } else {
                canGo = false;
            }
        }
        canGo = true;
        tmpCoordingate = Coordinate.AddPoints(pieceCoordinate, new Coordinate.Point{x=0, y=-1});
        while (canGo) {
            if (board.IsOnBoard(tmpCoordingate)) {
                listToReturn.Add(tmpCoordingate);
                tmpCoordingate = Coordinate.AddPoints(tmpCoordingate, new Coordinate.Point{x=0, y=-1}); 
            } else {
                canGo = false;
            }
        }
        canGo = true;
        tmpCoordingate = Coordinate.AddPoints(pieceCoordinate, new Coordinate.Point{x=1, y=1});
        while (canGo) {
            if (board.IsOnBoard(tmpCoordingate)) {
                listToReturn.Add(tmpCoordingate);
                tmpCoordingate = Coordinate.AddPoints(tmpCoordingate, new Coordinate.Point{x=1, y=1}); 
            } else {
                canGo = false;
            }
        }
        canGo = true;
        tmpCoordingate = Coordinate.AddPoints(pieceCoordinate, new Coordinate.Point{x=1, y=-1});
        while (canGo) {
            if (board.IsOnBoard(tmpCoordingate)) {
                listToReturn.Add(tmpCoordingate);
                tmpCoordingate = Coordinate.AddPoints(tmpCoordingate, new Coordinate.Point{x=1, y=-1}); 
            } else {
                canGo = false;
            }
        }
        canGo = true;
        tmpCoordingate = Coordinate.AddPoints(pieceCoordinate, new Coordinate.Point{x=-1, y=1});
        while (canGo) {
            if (board.IsOnBoard(tmpCoordingate)) {
                listToReturn.Add(tmpCoordingate);
                tmpCoordingate = Coordinate.AddPoints(tmpCoordingate, new Coordinate.Point{x=-1, y=1}); 
            } else {
                canGo = false;
            }
        }
        canGo = true;
        tmpCoordingate = Coordinate.AddPoints(pieceCoordinate, new Coordinate.Point{x=-1, y=-1});
        while (canGo) {
            if (board.IsOnBoard(tmpCoordingate)) {
                listToReturn.Add(tmpCoordingate);
                tmpCoordingate = Coordinate.AddPoints(tmpCoordingate, new Coordinate.Point{x=-1, y=-1}); 
            } else {
                canGo = false;
            }
        }
        return listToReturn;
    }
}
