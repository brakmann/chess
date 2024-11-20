using UnityEngine;
using System.Collections.Generic;
public class King : MonoBehaviour, IMoveable
{
    private Board board;
    public List<Coordinate.Point> GetAvailableSquares() {
        List<Coordinate.Point> listToReturn = new List<Coordinate.Point>();
        Coordinate.Point kingCoordingate = gameObject.GetComponent<Coordinate>().GetCoordinates();
        board = GameObject.FindGameObjectWithTag("Board").GetComponent<Board>();


        if (board.IsOnBoard(kingCoordingate, new Coordinate.Point{x=-1, y=-1})) {
            listToReturn.Add(new Coordinate.Point{x=kingCoordingate.x-1, y=kingCoordingate.y-1});
        }
        if (board.IsOnBoard(kingCoordingate, new Coordinate.Point{x=-1, y=0})) {
            listToReturn.Add(new Coordinate.Point{x=kingCoordingate.x-1, y=kingCoordingate.y});
        }
        if (board.IsOnBoard(kingCoordingate, new Coordinate.Point{x=-1, y=1})) {
            listToReturn.Add(new Coordinate.Point{x=kingCoordingate.x-1, y=kingCoordingate.y+1});
        }
        if (board.IsOnBoard(kingCoordingate, new Coordinate.Point{x=0, y=-1})) {
            listToReturn.Add(new Coordinate.Point{x=kingCoordingate.x, y=kingCoordingate.y-1});
        }
        if (board.IsOnBoard(kingCoordingate, new Coordinate.Point{x=0, y=1})) {
            listToReturn.Add(new Coordinate.Point{x=kingCoordingate.x, y=kingCoordingate.y+1});
        }
        if (board.IsOnBoard(kingCoordingate, new Coordinate.Point{x=1, y=-1})) {
            listToReturn.Add(new Coordinate.Point{x=kingCoordingate.x+1, y=kingCoordingate.y-1});
        }
        if (board.IsOnBoard(kingCoordingate, new Coordinate.Point{x=1, y=0})) {
            listToReturn.Add(new Coordinate.Point{x=kingCoordingate.x+1, y=kingCoordingate.y});
        }
        if (board.IsOnBoard(kingCoordingate, new Coordinate.Point{x=1, y=1})) {
            listToReturn.Add(new Coordinate.Point{x=kingCoordingate.x+1, y=kingCoordingate.y+1});
        }
        return listToReturn;
    }
}