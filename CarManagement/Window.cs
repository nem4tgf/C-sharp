using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarManagement
{
    public class Window
    {
        //construct takes two intergers to
        //fix location on the console
        public Window(int top, int left){
            this.top = top;
            this.left = left;
        }
        //simulates drawing the window 
        public virtual void DrawWindow(){
            Console.WriteLine("Window: drawing Window at {0}, {1}", top, left);
        }
        //these members are protected and thus visible
        //to derived class methods. we'll examine this
        //later in the chapter

        protected int top;
        protected int left;
    }
}