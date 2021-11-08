using System;
using System.Collections.Generic;
using System.Text;

namespace Game_2D
{
    class EmptyTile : Tile
    {
        public EmptyTile(int x, int y, string symbol, TileType tileType) : base(x, y, symbol, tileType) 
        { 
        
        }
    }
}
