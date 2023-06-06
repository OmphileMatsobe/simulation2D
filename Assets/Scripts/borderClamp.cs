using UnityEngine;

public class borderClamp : MonoBehaviour
{

    public void Update()
    {
        Vector2 puckPosition = new Vector2(Mathf.Clamp(transform.position.x,0, 0),
                                             Mathf.Clamp(transform.position.y, 0, 0));

        transform.position = puckPosition;
    }
}
