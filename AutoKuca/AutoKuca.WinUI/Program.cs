using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoKuca.WinUI.Modeli;


namespace AutoKuca.WinUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmLogin login = new frmLogin();
            if (login.ShowDialog()== DialogResult.OK)
            {
                if(login._id==1)
                    Application.Run(new frmAdminIndex());
                if (login._id == 3)
                    Application.Run(new frmIndexMA());
                if (login._id == 2)
                    Application.Run(new frmDijeloviIndex());
               

            }

        }
    }
}
