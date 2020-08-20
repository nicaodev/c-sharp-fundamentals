﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics.Services
{
    class PrintService<T>
    {
        private T[] _values = new T[10];
        private int _count = 0;


        public void AddValue(T value)
        {
            if (_count == 10)
                throw new InvalidOperationException("Está cheio");

            _values[_count] = value;
            _count++;
             
        }

        public T First()
        {
            if (_count == 0)
                throw new InvalidOperationException("Está vazio");

            return _values.First();
        }

        public void Print()
        {
            Console.Write("[");

            for (int i = 0; i < _count - 1; i++)
                Console.Write(_values[i] + ", ");

            if (_count > 0)
                Console.Write(_values[_count - 1]);

            Console.WriteLine("]");
        }
    }
}
