using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CrowsBedroom.Extensions;
using UnityEngine.Tilemaps;

namespace CrowsBedroom.OneStroke
{
    public class GameController : MonoBehaviour
    {
        [SerializeField] Tilemap _tilemap = null;
        MapDict _mapDict = null;

        void Start()
        {
            _mapDict = new MapDict(_tilemap);
            _mapDict.CreateDict();
        }
    }
}
