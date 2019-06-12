using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CrowsBedroom.Extensions;

namespace CrowsBedroom.OneStroke
{
    public class Cell
    {
        public string Name { get; }
        public bool HasVisited { get; set; }
        public bool IsWalkable { get; private set; }

        public Cell(string name, bool isWalkable)
        {
            Name = name;
            IsWalkable = isWalkable;
        }
    }
}
