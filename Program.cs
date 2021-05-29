using RBS_Restaurant_Billing_System.Layer_UI;
using System;
using System.Windows.Forms;

namespace RBS_Restaurant_Billing_System
{
    static class Program
    {
        static FormCollection formColln = Application.OpenForms;
        static ApplicationContext MainContext = new ApplicationContext();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainContext.MainForm = new Form_Login();
            Application.Run(MainContext);
        }
        public static void SetMainForm(Form MainForm)
        {
            formColln = Application.OpenForms;
            foreach (Form frm in formColln)
            {
                if (frm.Name == MainForm.Name)
                {
                    MainContext.MainForm = frm;
                    return;
                }
            }
            MainContext.MainForm = MainForm;
        }

        public static void ShowMainForm()
        {
            MainContext.MainForm.Show();
        }
    }
}
