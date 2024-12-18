using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu]
public class TileData : ScriptableObject
{
    public TileBase[] Tiles;
    public float health;
    public float slightDamage;
    public float muchDamage;
}
