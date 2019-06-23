using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CrowsBedroom.Extensions;
using UnityEngine.Tilemaps;
using UnityEngine.SceneManagement;

namespace CrowsBedroom.OneStroke
{
    public class Map : MonoBehaviour
    {
        [SerializeField] Tilemap _tilemap = null;
        MapDict _mapDict = null;
        [SerializeField] Color _visitedColor = Color.gray;

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
            _tilemap.SetColor(pos, _visitedColor);
        }

        public bool IsStageClear()
        {
            var isClear = _mapDict.IsStageClear();
            if (isClear)
            {
                StageClear();
            }
            return isClear;
        }

        void StageClear()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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
