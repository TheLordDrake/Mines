using System;
using System.Collections.Generic;
using System.Text;

namespace Mines
{
    class DungeonFloorFactory
    {
        Dictionary<string, char> tiles = new Dictionary<string, char>()
        {
            { "stone", ' '},
            { "floor", '.' },
            { "wall", '#' }
        };

        private int width;
        private int height;
        private int maxRooms;
        private int minRoomSize;
        private int maxRoomSize;
        private bool roomsOverlap;
        private int randomConnections;
        private int randomSpurs;
        private List<string> level;
        private List<int[]> roomList;
        private List<List<int>> corridorList;

        private int[] generateRoom()
        {
            int x, y, w, h = 0;
            Random rand = new Random();

            w = rand.Next(minRoomSize, maxRoomSize);
            h = rand.Next(minRoomSize, maxRoomSize);
            x = rand.Next(1, (width - w - 1));
            y = rand.Next(1, (height - h - 1));

            return new [] {x, y, w, h};
        }

        private bool RoomOverlapping(int[] room, List<int[]> roomList)
        {
            int x = room[0];
            int y = room[1];
            int w = room[2];
            int h = room[3];

            foreach (var currentRoom in roomList)
            {
                /* The rectangles don't overlap if one rectangle's
                 * minimum in some dimension is greater than the
                 * other's maximum in that dimension.
                 */

                if (x < (currentRoom[0] + currentRoom[2]) &&
                    currentRoom[0] < (x + w) &&
                    y < (currentRoom[1] + currentRoom[3]) &&
                    currentRoom[1] < (y + h)
                )
                {
                    return true;
                }
            }

            return false;
        }

        private List<int[]> CorridorBetweenPoints(int x1, int y1, int x2, int y2, string joinType = "either")
        {
            if (x1 == x2 && y1 == y2 || x1 == x2 || y1 == y2)
            {
                return new List<int[]> {new[] {x1, y1}, new[] {x2, y2}};
            }

            /*
            * 2 Corridors
            * NOTE: Never randomly choose a join that will go out of bounds
            * when the walls are added.
            */

            string join = null;
            if(joinType == "either" && )
        }
    }
}
