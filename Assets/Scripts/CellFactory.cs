using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CrowsBedroom.Extensions;
using System.Linq;

namespace CrowsBedroom.OneStroke
{
    // Immutable class
    static class CellFactory
    {
        static readonly Cell[] _cells = new Cell[]
        {
            new Cell(CellType.Road,        isWalkable: true),
            new Cell(CellType.VisitedRoad, isWalkable: false),
            new Cell(CellType.Wall,        isWalkable: false),
        };

        public static Cell GetInstance(CellType type)
        {
            return _cells.FirstOrDefault(x => x.Type == type);
        }
    }
}
