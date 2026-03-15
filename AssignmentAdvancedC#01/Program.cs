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

            #region Q4
            //generic method defines its own type parameters independent of the class it belongs to so there is no need to use generic class
            #endregion

            #region Q6
            //An interface that can work with any entity type.
            #endregion

            #region Q7
            //Stuct Constraint --> Must be a value type
            //example --> class ValueBox<T> where T : struct {
            //T can be int, double, bool but not string or class
            //}
            #endregion

            #region Q8
            //class constraint --> must be reference type
            //example --> class ReferenceBox<T> where T : class {T can be string or object}
            #endregion

            #region Q9
            //new() constraint --> must have a parameterless constructor
            //example --> class Factory<T> where T : new() {T can be any class with a default constructor}
            #endregion

            #region Q10
            //interface constraint --> Must implement a specific interface.
            //example --> class Repository<T> where T : IEntity {T can be any class that implements IEntity interface}
            #endregion

            #region Q11
            //Base class constraint --> Must inherit from a specific class
            //example --> class Service<T> where T : BaseService {T can be any class that inherits from BaseService}
            #endregion

            #region Q13
            //It returns the default value for a type null for reference types and 0/fasle for value types
            #endregion

            #region Q15
            //  Covariance(out) --> Allows you to use a more derived type than originally specified IEnumerable<string> can be treated as IEnumerable<object> it's for output only.
            #endregion

            #region Q16
            //Contravariance (in) --> Allows you to use a more generic (base) type than originally specified it's for input only.
            #endregion

            #region Q17
            //Covariance is about reading out (getting) but Contravariance is about passing in (setting).
            #endregion
        }

        #region Q4
        //public void Swap<T>(ref T a, ref T b)
        //{
        //    T temp = a;
        //    a = b;
        //    b = temp;
        //}
        #endregion

        #region Q5
        //public T FindMax<T>(T[] items) where T : IComparable<T>
        //{
        //    T max = items[0];
        //    foreach (var item in items)
        //    {
        //        if (item.CompareTo(max) > 0) max = item;
        //    }
        //    return max;
        //}
        #endregion

        #region Q6
        //public interface IRepository<T>
        //{
        //    void Add(T entity);
        //    T GetById(int id);
        //}
        #endregion
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

    #region Q12
    //public class DataHandler<T> where T : class, IComparable<T>, new()
    //{
    //    // T must be a class AND implement IComparable AND have a constructor
    //}
    #endregion

    #region Q14
    //public class SafeList<T>
    //{
    //    private List<T> _list = new();
    //    public T GetAt(int index) => (index >= 0 && index < _list.Count) ? _list[index] : default;
    //}
    #endregion

    #region Q19

    //internal class Base<T>
    //{
    //}
    //class Child<T> : Base<T> { }

    //class StringChild : Base<string> { } 
    #endregion
}
