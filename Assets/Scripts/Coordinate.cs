using UnityEngine;

public class Coordinate : MonoBehaviour
{
    public struct Point {public int x; public int y;} //why it should be public? Can i incapsulate it?
    private readonly Vector2 viewOrigin = new Vector2 (-0.56f, -0.56f);
    private readonly Vector2 viewScale = new Vector2 (0.16f, 0.16f);
    private Point coordinates; //should be 0-7. Shouldn't be SF when automatically spawns
    private void Update() {
        ApplyCoordinatesToView(); //Should be called every turn, not every frame
    }
    public void ApplyCoordinates(Point coordinates) { //maybe it should check if coord right?
        this.coordinates = coordinates;
    }
    private void ApplyCoordinatesToView(){
        transform.position = viewOrigin + new Vector2(coordinates.x * viewScale.x, coordinates.y * viewScale.y);
    }

    public Point GetCoordinates() {
        return coordinates;
    }
}
