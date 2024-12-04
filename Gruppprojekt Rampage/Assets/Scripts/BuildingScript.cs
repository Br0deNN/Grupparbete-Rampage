using UnityEngine;
using UnityEngine.Tilemaps;

public class BuildingScript : MonoBehaviour
{
    private TilemapCollider2D hitBox;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hitBox = GetComponent<TilemapCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            hitBox.enabled = true;
        }
        else
        {
            hitBox.enabled = false;
        }
    }
}
