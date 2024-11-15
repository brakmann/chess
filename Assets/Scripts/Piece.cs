using Unity.VisualScripting;
using UnityEngine;

public class Piece : MonoBehaviour
{
    [SerializeField] private Vector2 viewOrigin;
    [SerializeField] private Vector2 viewScale;
    private struct Point {public int x; public int y;}
    private Point coordinates; //should be 0-7
    private void Start() {
        coordinates.x = 0;
        coordinates.y = 0;
        ApplyCoordinatesToView();
    }
    private void ApplyCoordinatesToView(){
        transform.position = viewOrigin + new Vector2(coordinates.x * viewScale.x, coordinates.y * viewScale.y);
    }


}
