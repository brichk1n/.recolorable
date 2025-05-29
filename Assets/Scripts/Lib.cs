using UnityEngine;
public class Lib : MonoBehaviour
{

    public Vector2 GetPlayerPosition()
    {
        return transform.position;
    }
    public Vector2 GetDirectionToCursor()
    {
        Vector3 cursorWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector3 playerPos = transform.position;

        Vector2 di


        Vector2 cursorPos;
        cursorPos.x = Input.mousePosition.x;
        cursorPos.y = Input.mousePosition.y;
        print("curosorPos: " + cursorPos);

        Vector2 playerPos;
        playerPos.x = transform.position.x;
        playerPos.y = transform.position.y;
        print("playerPos: " + playerPos);

        Vector2 result;
        result.x = playerPos.x - cursorPos.x;
        result.y = playerPos.y - cursorPos.y;
        print("result: " + result);

        return result;
    }
}
