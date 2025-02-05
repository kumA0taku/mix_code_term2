﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayStackTest
{
    public class ArrayStack
    {
        protected object[] data;
        protected int pointer;

        public ArrayStack(int capacity)
        {
            data = new object[capacity];
            pointer = 0;
        }
        public bool isEmpty()
        {
            return pointer == 0;
        }
        public void push(object ob)
        {
            if (pointer < data.Length)
                data[pointer++] = ob;
        }
        public object pop()
        {
            if (isEmpty())
                return null;
            object oo = data[--pointer];
            data[pointer] = null;
            return oo;
        }
    }
}

