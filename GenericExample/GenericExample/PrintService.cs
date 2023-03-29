using System;

namespace GenericExample
{
    class PrintService<T> //Adiciona um tipo generico que pode ser qualquer caracter nes caso "<T>
                          //adiciona o tipo que quer usar na instanciação do objeto na classe program
    {
        private T[] _values = new T[10];
        private int _count = 0;

        public void AddValue(T value)
        {
            if(_count == 10)
            {
                throw new InvalidOperationException("PrintService is full");
            }

            _values[_count] = value;
            _count++;
        }

        public T First()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("PrintService is empity");
            }
            return _values[0];
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < _count -1; i++)
            {
                Console.Write(_values[i] + ", ");
            }
            if (_count > 0)
            {
                Console.Write(_values[_count - 1]);
            }
            Console.WriteLine("]");
        }
    }
}
