using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Model
{
    public class Vlak
    {
        public enum Size { Small, Large }
        private int capacity = Const.ZERO;
        private Size size;

        public Vlak(Size size)
        {
            this.size = size;
            if (size == Size.Small)
                capacity = Const.SMALL_TRAIN_SIZE;
            else
                capacity = Const.LARGE_TRAIN_SIZE;
        }

        public int GetCapacity() => capacity;
        public void SetCapacity() => capacity--;
        public Size GetSize() => size;
    }
}
