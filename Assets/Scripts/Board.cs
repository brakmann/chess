using UnityEngine;

public class Board : MonoBehaviour
{
    public bool IsOnBoard(Coordinate.Point point) {
        return point.x >= 0 && point.y >= 0 && point.x <= 7 && point.y <= 7;
    }
    public bool IsOnBoard(Coordinate.Point point, Coordinate.Point pointToMove) {
        return point.x + pointToMove.x >= 0 && point.y + pointToMove.y >= 0 && point.x + pointToMove.x <= 7 && point.y + pointToMove.y <= 7;
    }
}
