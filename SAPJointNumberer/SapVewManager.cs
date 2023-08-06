using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPJointNumberer
{
    public static class SapVewManager
    {
        public static void RefreshWindow()
        {
            SAP.Model.View.RefreshWindow();
        }
        public static void RefreshView()
        {
            SAP.Model.View.RefreshView();
        }
    }
}
