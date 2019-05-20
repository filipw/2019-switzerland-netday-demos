using System;

namespace Demo
{
    public class Christmas
    {
        public void CheckGifts()
        {
            var gift1 = ("toy", 25);
            var gift2 = ("game", 10);
            Console.WriteLine(gift1 == gift2);
        }
    }
}

//namespace System
//{
//    public struct ValueTuple<T1, T2>
//    {
//        public ValueTuple(T1 t1, T2 t2)
//        {
//        }

//        public static bool operator ==(ValueTuple<T1, T2> t1, ValueTuple<T1, T2> t2) => true;
//        public static bool operator !=(ValueTuple<T1, T2> t1, ValueTuple<T1, T2> t2) => false;
//    }
//}