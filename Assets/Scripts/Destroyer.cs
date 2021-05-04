using UnityEngine;

public class Destroyer : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        string tag = col.gameObject.tag;
        
        if (tag == "Obstacle" || tag == "Bird")
        {
            Destroy(col.gameObject);
        }
        else if (tag == "Enemy")
        {
            col.GetComponent<Enemy>().outOfBounds();
            Destroy(col.gameObject);
        }
    }
}