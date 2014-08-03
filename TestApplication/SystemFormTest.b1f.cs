using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAPbouiCOM.Framework;
using Dover.Framework.Form;

namespace TestApplication
{
    [FormAttribute("150", "SystemFormTest.b1f")]
    public class SystemFormTest : DoverSystemFormBase
    {
        public SystemFormTest()
        {
        }

        /// <summary>
        /// Initialize components. Called by framework after form created.
        /// </summary>
        public override void OnInitializeComponent()
        {
            this.StaticText0 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_0").Specific));
            this.StaticText1 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_1").Specific));
            this.Button0 = ((SAPbouiCOM.Button)(this.GetItem("Item_2").Specific));
            this.OnCustomInitialize();

        }

        /// <summary>
        /// Initialize form event. Called by framework before form creation.
        /// </summary>
        public override void OnInitializeFormEvents()
        {
        }

        private SAPbouiCOM.StaticText StaticText0;

        private void OnCustomInitialize()
        {

        }

        private SAPbouiCOM.StaticText StaticText1;
        private SAPbouiCOM.Button Button0;
    }
}
