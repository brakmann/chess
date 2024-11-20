using UnityEngine;
using System.Collections.Generic;
public class Knight : MonoBehaviour, IMoveable
{
    private Board board;
    public List<Coordinate.Point> GetAvailableSquares() {
        List<Coordinate.Point> listToReturn = new List<Coordinate.Point>();
        Coordinate.Point pieceCoordinate = gameObject.GetComponent<Coordinate>().GetCoordinates();
        Coordinate.Point tmpCoordinate;
        board = GameObject.FindGameObjectWithTag("Board").GetComponent<Board>();
        tmpCoordinate = Coordinate.AddPoints(pieceCoordinate, new Coordinate.Point{x=2, y=1});
        if (board.IsOnBoard(tmpCoordinate)) {
            listToReturn.Add(tmpCoordinate);
        }
        tmpCoordinate = Coordinate.AddPoints(pieceCoordinate, new Coordinate.Point{x=2, y=-1});
        if (board.IsOnBoard(tmpCoordinate)) {
            listToReturn.Add(tmpCoordinate);
        }
        tmpCoordinate = Coordinate.AddPoints(pieceCoordinate, new Coordinate.Point{x=1, y=2});
        if (board.IsOnBoard(tmpCoordinate)) {
            listToReturn.Add(tmpCoordinate);
        }
        tmpCoordinate = Coordinate.AddPoints(pieceCoordinate, new Coordinate.Point{x=1, y=-2});
        if (board.IsOnBoard(tmpCoordinate)) {
            listToReturn.Add(tmpCoordinate);
        }
        tmpCoordinate = Coordinate.AddPoints(pieceCoordinate, new Coordinate.Point{x=-1, y=2});
        if (board.IsOnBoard(tmpCoordinate)) {
            listToReturn.Add(tmpCoordinate);
        }
        tmpCoordinate = Coordinate.AddPoints(pieceCoordinate, new Coordinate.Point{x=-1, y=-2});
        if (board.IsOnBoard(tmpCoordinate)) {
            listToReturn.Add(tmpCoordinate);
        }
        tmpCoordinate = Coordinate.AddPoints(pieceCoordinate, new Coordinate.Point{x=-2, y=1});
        if (board.IsOnBoard(tmpCoordinate)) {
            listToReturn.Add(tmpCoordinate);
        }
        tmpCoordinate = Coordinate.AddPoints(pieceCoordinate, new Coordinate.Point{x=-2, y=-1});
        if (board.IsOnBoard(tmpCoordinate)) {
            listToReturn.Add(tmpCoordinate);
        }
        return listToReturn;
    }
}