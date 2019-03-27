using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    abstract class PersonsProcessor
    {
        abstract public void Process(IEnumerable<Person> person);
    }
}
