using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace NClass.Document
{
    public struct Shape
    {
        public Location location;
        public Size size;
        public readonly object image;
        public string title;
        public string notes;
        public readonly int Id;
        public readonly MapType category;
        public System.Drawing.Color background;
        public readonly int mapId;

        public Shape(int id, int mapId, MapType type, object image, string title)
        {
            this.Id = id;
            this.mapId = mapId;
            this.category = type;
            this.image = image;
            this.title = title;

            location = default(Location);
            size = default(Size);
            notes = string.Empty;
            background = Color.White;
        }
    }
}