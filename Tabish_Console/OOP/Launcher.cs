using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabish_Console.OOP
{
    class Launcher
    {

        //public static void Main()
        //{

        //    //Console.WriteLine("Do you want to enter id and name both ,press 1 for yes");
        //    //int option = Convert.ToInt32(Console.ReadLine());

        //    //Console.WriteLine("Enter default id");
        //    //int id = Convert.ToInt32(Console.ReadLine());

        //    ////if (option==1)
        //    ////{

        //    ////    Console.WriteLine("Enter default name");
        //    ////    string name = Console.ReadLine();

        //    ////    StudentSystem studentSystemType_1 = new StudentSystem(id,name);
        //    ////}
        //    ////else
        //    ////{
        //    ////  //  StudentSystem studentSystem = new StudentSystem(id);

        //    ////}

        //    //StudentSystem studentSystem = new StudentSystem(id);

        //    //Console.WriteLine("Enter real  id");
        //    //int realId = Convert.ToInt32(Console.ReadLine());

        //    //// studentSystem.SetDataID(realId);
        //    //studentSystem.Id = realId;//set

        //    ////Console.WriteLine("Enter real  Name");
        //    ////string realName = Console.ReadLine();
        //    ////studentSystem.SetDataName(realName);


        //    ////int callingId = studentSystem.GetDataID();
        //    //int callingId = studentSystem.Id;//get
        //   // string callingName = studentSystem.GetDataName();

        //   // Console.WriteLine($"your id is :{callingId} and name is {callingName}");

        //    //right side is object ---left is reference variable
        //    //  studentSystem.SetData(id, name);


        //    Console.ReadLine();



        //}

        //public static void Main() {

        //    COnstructorDestructorDemio obj = new COnstructorDestructorDemio();
        //   // obj.close();
        //    COnstructorDestructorDemio obj1 = new COnstructorDestructorDemio();

        //    //COnstructorDestructorDemio.MyData();
        //    Console.ReadLine();

        //}

        //public static void Main()
        //{

        //    //RectAngle shape = new RectAngle(); 
        //    //shape.Area();
        //    // shape.rectMethod();


        //    Shape obj = new Shape();


        //    Console.ReadLine();


        //}

        //It-1
        //public static void Main()
        //{
        //    ICalculator calc = InstanceCreator.CreateV1();
        //    calc.Add();



        //}

        //IT-2
        //public static void Main()
        //{
        //    ICalculatorNew calc = InstanceCreator.CReateV2();
        //    calc.Add();
        //    calc.Sub();


        //}

        //public static void Main()
        //{

        //    I1 obj = new calculation();
        //    obj.add();

        //    I2 obj1 = new calculation();
        //    obj.add();
        //}

        //public static void Main()
        //{
        //    int x = 1;
        //    int y = 2;


        //    KeywordsDemo demo = new KeywordsDemo();

        //    demo.Sum(ref x, ref y, out int z, out int m);
        //    Console.WriteLine($"{z} {m}");
        //    Console.WriteLine($"{x} {y}");
        //    Console.ReadLine();

        //}


        public static void Main()
        {
            // Console.WriteLine($"Enter the capacity for the {DateTime.Now.Year}");
            // int capcity = Convert.ToInt32(Console.ReadLine());

            // StudentsStrenghth obj = new StudentsStrenghth(capcity);

            // Console.WriteLine(obj.capacity);
            //// obj.capacity = 300;
            //// StudentsStrenghth.capacity = 200;
            // //Console.WriteLine(StudentsStrenghth.capacity);

            //string str = "Rakesh";//string immutable 
            //str = str + " " + "Kumar";

            //string data = string.Empty;
            //for (int i = 0; i < length; i++)
            //{
            //    data += data + " ";//new string data object---bulky
            //}


            //StringBuilder str = new StringBuilder();//Mutable
            //str.Append("Rakesh");
            //str.Append(" ");
            //str.Append("Kumar");

            //Console.WriteLine(str.ToString()); ;

            //StudentsStrenghth students = new StudentsStrenghth(10);
            //students.Name = "Rakesh";
            //students.RollNo = 1001;
            //students.Class = 10;

            ////object initialiser
            //var student = new StudentsStrenghth(10)
            //{

            //    Name = "Rakesh",
            //    RollNo = 1001,
            //    Class = 10
            //};

            //var myrecords=KeywordsDemo.TupleDemo();
            //Console.WriteLine($"{myrecords.Item1[0]}  {myrecords.Item2} {myrecords.Item3}");

            //Console.WriteLine("enetr the size");
            //int size = Convert.ToInt32(Console.ReadLine());
            //StudentsStrenghth[] arrStudents=new StudentsStrenghth[size];

            //List<StudentsStrenghth> students = new List<StudentsStrenghth>();
            //StudentsStrenghth s1 = new StudentsStrenghth{ Name = "Maya", Class = 1, RollNo = 2001 };
            //StudentsStrenghth s2 = new StudentsStrenghth { Name = "Maya", Class = 1, RollNo = 2001 };

            //students.Add(s1);
            //students.Add(s2);

            //var students = new List<StudentsStrenghth>

            //{
            //new StudentsStrenghth{ Name = "Maya", Class = 1, RollNo = 2001 },
            //new StudentsStrenghth { Name = "Maya", Class = 1, RollNo = 2001 }


            //};


            //foreach (var item in students)
            //{
            //    Console.WriteLine($"{item.Name} {item.RollNo} {item.Class}");
            //}

            //ArrayList arrList=new ArrayList {
            //new StudentsStrenghth{ Name = "Maya", Class = 1, RollNo = 2001 },
            //new StudentsStrenghth { Name = "Maya", Class = 1, RollNo = 2001 },
            //"Rahul"


            //};

            //foreach (var item in arrList)
            //{
            //    if (item.GetType().Equals(typeof(StudentsStrenghth)))
            //    {
            //        var student = (StudentsStrenghth)item;
            //        Console.WriteLine($"{student.Name} {student.RollNo} {student.Class}");
            //    }
            //    else
            //    {
            //        Console.WriteLine(item);
            //    }

            //}

            //            Console.WriteLine(arrStudents.Length);


            //int Maharashtra = 12000;
            //int TamilNadu = 30000;
            //int Delhi = 50000;

            //int Dubai = 80000;
            //int abudhabi = 20000;

            //int IndiaPopulation = Maharashtra + TamilNadu + Delhi;
            //int UAEPopulation = Dubai + abudhabi;

            //Dictionary<string, int> countryPopulation = new Dictionary<string, int>();
            //countryPopulation.Add("India", IndiaPopulation);
            //countryPopulation.Add("uaePopulation", UAEPopulation);

            ////from yopu said

            //countryPopulation.TryGetValue("India", out int populationofIndia);
            //countryPopulation.TryGetValue("uaePopulation", out int populationofUAE);

            //Console.WriteLine($"Population of India ={populationofIndia} and population of UAE={populationofUAE}");

            //List<string> countries = new List<string>() {
            //"India","Singapore"

            //};



            List<int> lstOne = new List<int> { 1, 2, 3 };
            List<int> lsttwo = new List<int> { 1, 2, 3 };

            //List<List<int>> lstodLst = new List<List<int>> {
            //lstOne,
            //lsttwo
            //};

            List<List<int>> lstodLst = new List<List<int>>();
            lstodLst.Add(lstOne);
            lstodLst.Add(lsttwo);


            foreach (var lst in lstodLst)
            {
                foreach (var item in lst)
                {
                    Console.WriteLine(item);
                }
            }




            Console.ReadLine();

        }
    }


}



//(new StudentSystem()).ShowData();
//(new StudentSystem()).GetData();