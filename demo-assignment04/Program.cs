namespace demo_assignment04
{
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
            throw new NotImplementedException();
        }
    }
    internal class Program
    {
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
            //you can create a refrence from interface
            //clr will associate 4 bytes for refrence "myType"
            //refrence "myType" refer to "Null"
            //refrence "myType" can refer to object fro class or struc Implement that interface
            #endregion
        }
    }
}
