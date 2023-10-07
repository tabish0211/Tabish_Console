using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabish_Console.OOP
{
   public class StudentSystem
    {
        //private directly 
        ////instance data member 
        //private int _id;
        //private string _name;

        public string Id { get; set; }
        public int Name { get; set; }

        //constructor overloading 
        //public StudentSystem(string name)
        //{
        //    _name = name;

        //}
        //public StudentSystem(int id)
        //{
        //    _id = id;
        
        //}
        //public StudentSystem(int id,string name): this(name)
        //{
        //    //_id = id;//violation of DRY 
            
        //    _name = name;

        //}
        //private
        public void ShowData()
        {

            Console.WriteLine("You are calling student system");
        }

        
        //dotnet 2.0

        //public int Id
        //{
        //    set {

        //        _id = value;
        //    }

        //    get {

        //        return _id;

        //    }
        //}
        //public void SetDataID(int id)
        //{

        //    _id = id;
           
        //}

        //public void SetDataName(string name)
        //{

        //    _name = name;

        //}

        //public int GetDataID()
        //{

        //    return _id;

        //}

        //public string GetDataName()
        //{

        //    return _name;

        //}

    }
}
