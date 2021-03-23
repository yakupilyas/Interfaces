using System;

namespace Interfaces
{
    class Program
    {
        //interface new'lenemez
        static void Main(string[] args)
        {
           // IPersonManager customerManager = new CustomerManager();  
          //  IPersonManager employeeManager = new EmployeeManager();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());
        }
    }
   interface IPersonManager
    {
        void Add();
        void update();
        
    }

    //inherits - class --------- implements - interface
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //müşteri ekleme kodları
            Console.WriteLine("Müşteri eklendi");
        }

        public void update()
        {
            Console.WriteLine("Müşteri güncellendi");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //personel ekleme kodları
            Console.WriteLine("Personel eklendi");
        }

        public void update()
        {
            Console.WriteLine("Personel güncellendi");
        }
      
    }
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajer eklendi");
        }

        public void update()
        {
            Console.WriteLine("Stejer güncellendi");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
        
    }
}
