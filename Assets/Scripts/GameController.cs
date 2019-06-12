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
        PlayerController _player = null;

        void Start()
        {
            _mapDict = new MapDict(_tilemap);
            _mapDict.CreateDict();
            _mapDict.Log();
        }

        /// <summary>
        /// Update is called every frame, if the MonoBehaviour is enabled.
        /// </summary>
        void Update()
        {
            
        }
    }
}
