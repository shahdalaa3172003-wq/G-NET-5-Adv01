using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace advancedc_01
{

    
    internal class Program
    {
        #region Q4
        // static void swapmethod<T>(ref T first,ref T second)
        //{ T temp = first;
        //    T firet = second;
        //    second = temp;
        //   }

        #endregion
        #region Q5
        //static T findmax<T>(T[] numbers ) where T :INumber<T>
        //{
        //    T max = numbers[0];
        //    for (int i = 1; i < numbers.Length; i++) { 
            
        //    if(max < numbers[i]) {
        //            max = numbers[i];
            
            
        //    }
        //    return max;


        #endregion




        static void Main(string[] args)
        {

            #region Q1
            // it i a class that can work with any date type using type prameter like T 
            #endregion
            #region Q2
            //    Public class container<T>
            //    private List<T> items = new List<T>();
            ////add method
            //public  void add(T  item)=> items.Add(item);

            //// get method
            //public void get (int index) => items[index];


            #endregion

            #region Q3


            //Public class pair <T1,T2>
            //public T1 first { get; set; }
            //public T2 secand { get; set; }

            #endregion

            #region Q6
            // generic interface is an interface uses a type parameter T to work with different date type 
            #endregion
            #region Q7
            // struct cconstrain mean  type must be value type like int double ...
            //    Public class myclass<T> where T : struct { 

            //public T Value { get; set; }
            //}


            #endregion

            #region Q8
            // class constrain mean  type must be reference type  like string ,class
            //    Public class myclass<T> where T : class { 

            //public T name  { get; set; }
            //}


            #endregion

            #region Q9
            //new() constrain mean have parameterless constraint 
            #endregion
            #region Q10
            // the interface constraint ensure that the type parameter T implement a specific interface
            //static T findmax<T>(T[] numbers ) where T :INumber<T>
            //{
            //    T max = numbers[0];
            //    for (int i = 1; i < numbers.Length; i++) { 

            //    if(max < numbers[i]) {
            //            max = numbers[i];


            //    }
            //    return max;

            #endregion

            #region Q11
            // the interface constraint ensure that the type parameter T must inherit from a specific base class 
            #endregion

            #region Q12
            //multiple constraints can be applied to a generic type using the where clause

            //static T findmax<T>(T[] numbers ) where T :struct ,INumber<T>
            //{
            //    T max = numbers[0];
            //    for (int i = 1; i < numbers.Length; i++) { 

            //    if(max < numbers[i]) {
            //            max = numbers[i];


            //    }
            //    return max;

            #endregion

            #region Q13

            // the default  keyword  returns the default value of a type  parameter T in generics 



            #endregion

            #region 14
            //    Public class safelist<T>
            //{
            //    private List<T> _items = new List<T>();
            //    public void Add(T item) {
            //    _items.Add(item);

            //    }
            //    public void get(int index) {

            //    if(index <0)
            //            return default(T);
            //    return _items[index];
            //    }
            #endregion

            #region Q15
            // convariance allows a generic type with a derived type to be assigned to  a generic type 
            // of a base type using out keyword 
            #endregion
            #region Q16
            // convariance allows a generic type with a base type to be assigned to  a generic type 
            // of a base type using in keyword 
            #endregion
            #region Q17
            // covariance allows using a more derived type than specified out - output
            //while contravariance allows using a less derived type in-input 

            #endregion
            #region Q18
            //static members in generic classes are specific to each closed type  
            #endregion

            #region Q19
            //    Public class baseclass<T>
            //{ public T value; }
            //public class drivedclass: baseclass<T> { }
            #endregion



            #region Q20

            #endregion
        }



    }


}
