using System;

namespace ComposicaoObjetos.Entities
{
    internal class Department
    {
        public String Name { get; set; }     

        public Department() 
        { 
        }

        public Department(String name) 
        {
            Name = name;    
        }  
    }
}
