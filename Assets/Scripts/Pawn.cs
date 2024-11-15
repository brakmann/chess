using System.Collections.Generic;
using System.Drawing;
using Unity.Collections;
using UnityEngine;

public class Pawn : MonoBehaviour, IMoveable
{
    private Coordinate coordinate;
    private void Start() {
        Move(new Coordinate.Point{x=0, y=0});//test
    }
    public List<Coordinate.Point> GetAvailableSquares() {
        List<Coordinate.Point> listToReturn = new List<Coordinate.Point>();
        listToReturn.Add(new Coordinate.Point{x=4, y=4});
        return listToReturn;
    }
    public void Move(Coordinate.Point coordinateToMove) {//should containt logic of moving a pawn
        coordinate = gameObject.GetComponent<Coordinate>();
        coordinate.ApplyCoordinates(coordinateToMove);
    }
}
