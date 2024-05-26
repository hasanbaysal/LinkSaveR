using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.Pkcs;

namespace HB.LinkSaver
{
    internal static class Program
    {

        public static MainForm MainFrm = new MainForm();
        [STAThread]
        static void Main()
        {

            Application.ThreadException += new ThreadExceptionEventHandler(ThreadExceptionHandler);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(GlobalExceptionHandler);
            ApplicationConfiguration.Initialize();
            Application.Run(MainFrm);
        }

        static void GlobalExceptionHandler(object sender, UnhandledExceptionEventArgs args)
        {
            MessageBox.Show("An error occurred, and the application will be restarted later. You can submit the log file to the \"Issues\" section on GitHub.");
            WriteLog((Exception)args.ExceptionObject);
            Application.Restart();
        }

        static void ThreadExceptionHandler
        (object sender, System.Threading.ThreadExceptionEventArgs e)
        {

            MessageBox.Show("An error occurred, and the application will be restarted later. You can submit the log file to the \"Issues\" section on GitHub.");
            WriteLog(e.Exception);
            Application.Restart();

        }

        public static void WriteLog(Exception? exception)
        {
            if (exception == null) return;

            var ýd = Guid.NewGuid();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "LOGS");
            if (!Directory.Exists(path))
                Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "LOGS"));

           var filePath =  Path.Combine(path, $"{ýd}.txt");

            var data = exception.Source;
            data += Environment.NewLine + "--------------------";
            data += Environment.NewLine + exception.Message;
            data += Environment.NewLine + "--------------------";
            data += Environment.NewLine + exception.StackTrace;
            data += Environment.NewLine + "--------------------";
            
            File.WriteAllText(filePath,data);  
          

        }
    }
}