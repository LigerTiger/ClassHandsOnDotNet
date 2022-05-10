using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aparment
{
    class _2BHK
    {
        public virtual void Kitchen() { }
        public virtual void Hall() { }
        public void StudyRoom() { }
        public void BedRoom() { }
    }
    class _101:_2BHK
    {
        public override void Hall()
        {
           //re-defining
        }
        public override void Kitchen()
        {
            //extending
            base.Kitchen();
        }
    }
    class _102:_2BHK
    {

    }
    internal class Demo1
    {
    }
}
