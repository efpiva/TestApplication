using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAPbouiCOM.Framework;
using Dover.Framework.Attribute;
using Dover.Framework.Form;

namespace TestApplication
{
    [Menu(FatherUID = "43535", UniqueID = "exUF", String = "Exception UserForm", Type = SAPbouiCOM.BoMenuType.mt_STRING)]
    [MenuEvent(UniqueUID="exUF")]
    [FormAttribute("TestApplication.UserFormExTest", "TestApplication.UserFormExTest.srf")]
    public class UserFormExceptionTest : DoverUserFormBase
    {
        public UserFormExceptionTest()
        {
            throw new Exception("Some hidden InnerException that explains everything!");
        }

    }
}
