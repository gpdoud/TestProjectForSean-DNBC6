using System;

namespace BusinessPackage {
    public class Ball : Base {

        public int Id { get; private set; }
        public string Color { get; set; }
        public string Size { get; set; }

        public Ball() {
            this.Id = 0;
        }
        public Ball(string color, string size) : this() {
            this.Color = color;
            this.Size = size;
        }
    }
    public class Base {
        public int Code { get; set; }
    }
}
