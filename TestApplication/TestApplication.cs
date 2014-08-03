using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dover.Framework;
using Dover.Framework.Attribute;

namespace TestApplication
{
    [ResourceBOM("TestApplication.ExportUDO.xml", ResourceType.UDO)]
    [ResourceBOM("TestApplication.ExportUDT.xml", ResourceType.UserTable)]
    [ResourceBOM("TestApplication.ExportUDF.xml", ResourceType.UserField)]
    [AddIn(B1SResource="TestApplication.forms.b1s", Description="My test application without license", ChangeLogResource="TestApplication.ChangeLog.txt")]
    static class TestApplication
    {
        static void Main(string[] args)
        {
            Application b1App = new Application();
            b1App.Run();
        }        
    }
}
