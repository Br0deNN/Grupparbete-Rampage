using NUnit.Framework;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UIElements;

public class MapManager : MonoBehaviour
{
    [SerializeField]
    private Tilemap map;

    [SerializeField]
    private TileBase partDamage;



    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3Int gridPosition = map.WorldToCell(mousePosition);

            TileBase clickedTile = map.GetTile(gridPosition);

            print("At position " + gridPosition + " there is a " +  clickedTile);
        }
    }

    public TileBase GetTileData(Vector3Int tilePosition)
    {
        TileBase tile = map.GetTile(tilePosition);
        return tile;
    }

    public void damageTaken(Vector3Int position)
    {
        Debug.Log("Sigma");
        map.SetTile(position, partDamage);
    }
}
