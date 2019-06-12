using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CrowsBedroom.Extensions;
using System.Linq;

namespace CrowsBedroom.OneStroke
{
    static class CellFactory
    {
        static Cell[] _cells = new Cell[]
        {
            new Cell("Floor", isWalkable: true),
            new Cell("Aisle", isWalkable: false),
        };

        public static Cell GetInstance(string name)
        {
            return _cells.FirstOrDefault(x => x.Name == name);
        }
    }
}
