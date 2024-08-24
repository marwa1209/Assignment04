namespace demo_assignment04
{
    #region interface
    //IMytype (internal(default) or public)
    interface IMytype
    {
        ///what  we can write inside interface
        ///1.signature for property
        ///signature for property  it is not auto property
        public int Id { get; set; }
        ///2.signature for method 
        public void myFun(int x);
        ///3.Default implementation=>after c#6 
        public void print()
        {
            Console.WriteLine("hello");
        }
        ///Default access modifier public ,private not allowed


    }
    class Mytype : IMytype
    {
        //full property
        //private int id;
        //int IMytype.MyProperty 
        //{ 
        //get { return id; }
        //set { id = value; }
        //}
        //auto property
        public int Id { get; set; }
        void IMytype.myFun(int x)
        {
            Console.WriteLine(x);
        }
    }
    #endregion

    #region interfaceEx01
    interface ISeries
    {
        public int Current { get; set; }
        public void GetNext();
        public void Reset();

    }
    class SeriesByTwo : ISeries
    {
        public int Current { get ; set; }

        public void GetNext()
        {
            Current += 2;
        }

        public void Reset()
        {
            Current = 0;
        }
    }
    class SeriesByThree : ISeries
    {
        public int Current { get; set; }

        public void GetNext()
        {
            Current += 3;
        }

        public void Reset()
        {
            Current = 0;
        }
    }
    #endregion
    internal class Program
    {
        public static void Print10NunbersFromSeries(ISeries series)
        {
            if (series is not null)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(series.Current);
                    series.GetNext();
                }
                series.Reset();
            }
        }
        static void Main(string[] args)
        {
            #region Interface
            //refrence type dataType
            //code contract  between two developers
            //invalid=> IMytype mytype = new IMytype();
            //invalid=>  mytype.id=""
            //invalid=>  mytype.Myfun=""
            //
            //valid way
            IMytype myType;
            myType=new Mytype();
            myType.Id = 1;
            //you can create a refrence from interface
            //clr will associate 4 bytes for refrence "myType"
            //refrence "myType" refer to "Null"
            //refrence "myType" can refer to object fro class or struc Implement that interface
            #endregion

            #region InterfaceEx01
            ISeries series = new SeriesByTwo();
            Print10NunbersFromSeries(series);
            ISeries series02 = new SeriesByThree();
            Print10NunbersFromSeries(series02);
            #endregion

            #region Shallow Copy vs Deep Copy

            #region shallow copy[stack]
            int[] Arr01 = { 1, 2, 3 };
            int[] Arr02 = new int[3]; // {0, 0, 0}
            Console.WriteLine($"HC Of Arr01 = {Arr01.GetHashCode()}"); // Hash code of Arr01
            Console.WriteLine($"HC Of Arr02 = {Arr02.GetHashCode()}"); // Hash code of Arr02
            Arr02 = Arr01; // Shallow copy
            Console.WriteLine("After Shallow Copy");
            Console.WriteLine($"HC Of Arr01 = {Arr01.GetHashCode()}"); // Hash code of Arr01
            Console.WriteLine($"HC Of Arr02 = {Arr02.GetHashCode()}"); // Hash code of Arr02 (Same as Arr01)
            Console.WriteLine($"Arr01[0] = {Arr01[0]}"); // 1
            Console.WriteLine($"Arr02[0] = {Arr02[0]}"); // 1
            Arr02[0] = 100;
            Console.WriteLine("After Arr02[0] = 100");
            Console.WriteLine($"Arr01[0] = {Arr01[0]}"); // 100
            Console.WriteLine($"Arr02[0] = {Arr02[0]}"); // 100
            #endregion

            #region deep copy[heap ]
            Arr02 = (int[])Arr01.Clone();
            /// Clone => Deep Copy
            /// Deep Copy Occurred At Heap
            /// Create New Object With Different and New Identity
            /// That Object Will be The Same Object State [Data] Of Caller [Arr01]
            /// Return to An Object
            
            Arr02[0] = 100;
            Console.WriteLine($"Arr01[0] = {Arr01[0]}"); 
            Console.WriteLine($"Arr02[0] = {Arr02[0]}"); 
            #endregion

            #endregion


        }
    }
}
