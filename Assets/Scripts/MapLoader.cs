using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CrowsBedroom.Extensions;
using UnityEngine.Tilemaps;

namespace CrowsBedroom.OneStroke
{
    public class MapLoader : MonoBehaviour
    {
        [ContextMenu("Load1")]
        public void Load1()
        {
            var map = TMXLoader.Load(1);
            DrawMap(map);
        }

        [SerializeField] Tilemap _tilemap = null;
        [SerializeField] TileBase _floor = null;
        [SerializeField] TileBase _aisle = null;

        void DrawMap(Layer2D layer)
        {
            for (int y = 0; y < layer.height; y++)
            {
                for (int x = 0; x < layer.width; x++)
                {
                    var p = new Vector3Int(x, -y, 0);
                    var t = layer.Get(x, y) == 3 ? _floor : _aisle;
                    _tilemap.SetTile(p, t);
                }
            }
        }

        public void Dump(Layer2D layer)
        {
            print("[Layer2D] (w,h)=(" + layer.width + "," + layer.height + ")");
            for (int y = 0; y < layer.height; y++)
            {
                string s = "";
                for (int x = 0; x < layer.width; x++)
                {
                    s += layer.Get(x, y) + ",";
                }
                print(s);
            }
        }
    }
}
