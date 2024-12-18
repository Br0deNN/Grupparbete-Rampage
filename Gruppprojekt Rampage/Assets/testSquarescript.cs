using UnityEngine;
using UnityEngine.Tilemaps;

public class testSquarescript : MonoBehaviour
{
    private MapManager mapManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("I collided");
        if (collision.CompareTag("Building"))
        {
            Debug.Log("I building");
            Vector3Int v = new Vector3Int((int)collision.transform.position.x, (int)collision.transform.position.y);
            // mapManager.GetTileData(v);
            mapManager.damageTaken(v);
        }
    }
}
