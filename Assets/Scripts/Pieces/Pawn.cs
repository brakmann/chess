using System.Collections.Generic;
using UnityEngine;
public class Pawn : MonoBehaviour, IMoveable
{
    private Board board;
    public List<Coordinate.Point> GetAvailableSquares() {
        List<Coordinate.Point> listToReturn = new List<Coordinate.Point>();
        Coordinate.Point pieceCoordinate = gameObject.GetComponent<Coordinate>().GetCoordinates();
        Coordinate.Point tmpCoordingate;
        board = GameObject.FindGameObjectWithTag("Board").GetComponent<Board>();
        tmpCoordingate = Coordinate.AddPoints(pieceCoordinate, new Coordinate.Point{x=0, y=1}); 
        if (board.IsOnBoard(tmpCoordingate)) {
            listToReturn.Add(tmpCoordingate);
        }
        return listToReturn;
    }
}
