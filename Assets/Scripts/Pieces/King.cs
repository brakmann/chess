using UnityEngine;
using System.Collections.Generic;
public class King : MonoBehaviour, IMoveable
{
    private Board board;
    public List<Coordinate.Point> GetAvailableSquares() {
        List<Coordinate.Point> listToReturn = new List<Coordinate.Point>();
        Coordinate.Point kingCoordinate = gameObject.GetComponent<Coordinate>().GetCoordinates();
        Coordinate.Point tmpCoordingate;
        board = GameObject.FindGameObjectWithTag("Board").GetComponent<Board>();
        tmpCoordingate = Coordinate.AddPoints(kingCoordinate, new Coordinate.Point{x=1, y=1});
        if (board.IsOnBoard(tmpCoordingate)) {
            listToReturn.Add(tmpCoordingate);
        }
        tmpCoordingate = Coordinate.AddPoints(kingCoordinate, new Coordinate.Point{x=1, y=0});
        if (board.IsOnBoard(tmpCoordingate)) {
            listToReturn.Add(tmpCoordingate);
        }
        tmpCoordingate = Coordinate.AddPoints(kingCoordinate, new Coordinate.Point{x=1, y=-1});
        if (board.IsOnBoard(tmpCoordingate)) {
            listToReturn.Add(tmpCoordingate);
        }
        tmpCoordingate = Coordinate.AddPoints(kingCoordinate, new Coordinate.Point{x=0, y=1});
        if (board.IsOnBoard(tmpCoordingate)) {
            listToReturn.Add(tmpCoordingate);
        }
        tmpCoordingate = Coordinate.AddPoints(kingCoordinate, new Coordinate.Point{x=0, y=-1});
        if (board.IsOnBoard(tmpCoordingate)) {
            listToReturn.Add(tmpCoordingate);
        }
        tmpCoordingate = Coordinate.AddPoints(kingCoordinate, new Coordinate.Point{x=-1, y=1});
        if (board.IsOnBoard(tmpCoordingate)) {
            listToReturn.Add(tmpCoordingate);
        }
        tmpCoordingate = Coordinate.AddPoints(kingCoordinate, new Coordinate.Point{x=-1, y=0});
        if (board.IsOnBoard(tmpCoordingate)) {
            listToReturn.Add(tmpCoordingate);
        }
        tmpCoordingate = Coordinate.AddPoints(kingCoordinate, new Coordinate.Point{x=-1, y=-1});
        if (board.IsOnBoard(tmpCoordingate)) {
            listToReturn.Add(tmpCoordingate);
        }
        return listToReturn;
    }
}