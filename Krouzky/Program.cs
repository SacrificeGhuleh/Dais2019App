using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krouzky {
    using System.Threading;

    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static bool offline = false;

        [STAThread]
        static void Main() {
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
