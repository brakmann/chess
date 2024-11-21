using UnityEngine;

public class Board : MonoBehaviour
{
    private bool IsOnBoard(Coordinate.Point point) {
        return point.x >= 0 && point.y >= 0 && point.x <= 7 && point.y <= 7;
    }
    private bool IsFree(Coordinate.Point point) {
        GameObject[] pieces = GameObject.FindGameObjectsWithTag("Piece");
        foreach (GameObject piece in pieces) {
            if (piece.GetComponent<Coordinate>().GetCoordinates().x == point.x && piece.GetComponent<Coordinate>().GetCoordinates().y == point.y) {
                return false;
            }
        }
        return true;
    }
    public bool CanPlace(Coordinate.Point point) {
        return IsOnBoard(point) && IsFree(point);
    }
}
