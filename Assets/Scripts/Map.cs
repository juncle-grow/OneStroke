using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CrowsBedroom.Extensions;
using UnityEngine.Tilemaps;

namespace CrowsBedroom.OneStroke
{
    public class Map : MonoBehaviour
    {
        [SerializeField] Tilemap _tilemap = null;
        MapDict _mapDict = null;

        void Awake()
        {
            _mapDict = new MapDict(_tilemap);
            _mapDict.CreateDict();
        }

        // NAME: There should be better name.
        public void DisableWalk(Vector3Int pos)
        {
            _mapDict.SetCell(pos, CellFactory.GetInstance(CellType.Wall));
            _tilemap.SetTileFlags(pos, TileFlags.None);
            _tilemap.SetColor(pos, Color.gray);
        }

        // NAME:「問題を解いた」にしたい
        public bool IsGameClear()
        {
            var isClear = _mapDict.IsGameClear();
            if (isClear)
            {
                GameClear();
            }
            return isClear;
        }

        // NAME:「問題を解いた」にしたい
        void GameClear()
        {
            Debug.LogError("Game Clear!");
        }

        public bool IsWalkable(Vector3Int playerPos)
        {
            var cell = _mapDict.GetCell(playerPos);
            if (cell == null)
            {
                return false;
            }
            return cell.IsWalkable;
        }
    }
}
