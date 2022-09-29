using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordConsoleApp
{

    public record Teacher(string firstname, string lastname, string grade) :
        Person(firstname, lastname);
    public record Person(string Firstname, string Lastname)
    {
        //public int MyProperty { get; set; }
    }
}
