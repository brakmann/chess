using System.Drawing;
using Unity.Collections;
using UnityEngine;

public class Pawn : MonoBehaviour, IMoveable
{
    private Coordinate coordinate;
    public void Move(Coordinate.Point coordinateToMove) {//should containt logic of moving a pawn
        coordinate = gameObject.GetComponent<Coordinate>();
        coordinate.ApplyCoordinates(coordinateToMove);
    }

    private void Start() {
        Move(new Coordinate.Point{x=0, y=0});
    }

    //Coordinate.Point[] GetAvailableSquares();

}
