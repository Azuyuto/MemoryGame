﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GraMemory.Model
{
    public class ComboboxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
