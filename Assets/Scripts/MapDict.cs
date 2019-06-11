using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CrowsBedroom.Extensions;
using UnityEngine.Tilemaps;
using UnityEngine.SceneManagement;
namespace CrowsBedroom.OneStroke
{
    public class MapDict
    {
        Tilemap _tilemap = null;
        Dictionary<Vector3Int, Cell> _mapDict = null;

        public MapDict(Tilemap tilemap)
        {
            _tilemap = tilemap;
            _mapDict = new Dictionary<Vector3Int, Cell>();
        }

        public void CreateDict()
        {
            // Optimize bounds to use it easily.
            _tilemap.CompressBounds();

            foreach (var pos in _tilemap.cellBounds.allPositionsWithin)
            {
                TileBase tile = _tilemap.GetTile(pos);

                if (tile == null)
                {
                    Debug.LogWarning(pos + "null");
                    continue;
                }

                Debug.Log(pos + tile.name);
            }
        }
    }
}
