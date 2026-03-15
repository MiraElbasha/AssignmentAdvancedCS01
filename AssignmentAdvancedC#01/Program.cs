using System.Reflection.Metadata;

namespace AssignmentAdvancedC_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Generic class is a blueprint that use type parameter <T> to allow one declaration and multiple implementation
            //why to use generics 
            /* 1. Code reusability: we can use the same code for different data types without rewriting it
               2. Type safety: it provides compile-time type checking, which helps to prevent runtime errors
               3. Performance: it decreare the need for boxing and unboxing when using value types which can improve performance
            */
            #endregion

            #region Q3
            //Multiple type parameters allow a class to handle more than one "placeholder" type at once like class , Iinterface , new()
            #endregion

        }
    }

             #region Q2
    //public class Container<T>
    // {
    //      private T _item;
    //      public void Add(T item) => _item = item;
    //      public T Get() => _item;
    // }
    #endregion

             #region Q3
    //public class Pair<TKey, TValue>
    //{
    //    public TKey Key { get; set; }
    //    public TValue Value { get; set; }
    //}
    #endregion
}
