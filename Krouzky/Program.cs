#region UsingRegion

using System;
using System.Threading;
using System.Windows.Forms;

#endregion

namespace Krouzky {
    internal static class Program {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        private static readonly bool offline = false;

        [STAThread]
        private static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ORM.ORM orm_ = null;

            bool err = false;
            var loading = new FormLoading();

            if (!offline) {
                loading.Show();
                Thread t = new Thread(() => {
                    try {
                        orm_ = ORM.ORM.instance;
                    }
                    catch (Exception e) {
                        loading.setErrorText(e);
                        err = true;
                    }
                });
                t.Start();

                t.Join();
            }

            if (err) {
                Application.Run(loading);
            }
            else {
                loading.Close();
                Application.Run(new FormKrouzkyMain(ORM.ORM.instance));
            }
        }
    }
}