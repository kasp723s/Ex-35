﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_35
{
    public class ConcreteSubject : Subject
    {
        private int state = 0;
        public int State
        {
            get { return state; }
            set { state = value; Notify(); }
        }
       
        
          
    }
}
