using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CrowsBedroom.Extensions;

namespace CrowsBedroom.OneStroke
{
    public enum CellType
    {
        Road,
        VisitedRoad,
        Wall,
    }

    // Immutable class
    public class Cell
    {
        public readonly CellType Type;
        public readonly bool IsWalkable;
        public readonly bool HasVisited;

        public Cell(CellType type, bool isWalkable)
        {
            Type = type;
            IsWalkable = isWalkable;
        }
    }
}
