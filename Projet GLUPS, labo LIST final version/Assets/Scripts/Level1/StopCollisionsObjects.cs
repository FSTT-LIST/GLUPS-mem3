using UnityEngine;

public class StopCollisionsObjects : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        Physics2D.IgnoreLayerCollision(8,9);
        Physics2D.IgnoreLayerCollision(8, 10);
        Physics2D.IgnoreLayerCollision(9, 10);
    }
}
