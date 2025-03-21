using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace HB.LinkSaver
{
    internal static class Program
    {



        //TODO : HB api new  end-point - category group get 
        //TODO : HB extention d�zenlemesi
        //TODO : HB using TempFile  to protect main json files
        //TODO : HB Change pages structure
        //TODO : HB Api endpoint fix

        public static string AllCategoryGroup = "All";
        public static MainForm MainFrm = new MainForm();
        public static WebApplication WebApp { get; set; }
        public static string GlobalMessage { get; set; } = string.Empty;
        public static bool ServerStatus { get; set; }
        public static Mutex AppMutex { get; private set; }

        

        [STAThread]
        static async Task Main()
        {


            Mutex AppMutex = new Mutex(false, "32494563679101");

                if (!AppMutex.WaitOne(0, false))
                {
                    //single instance  check!
                    MessageBox.Show("Instance already running");
                    return;
                }

                Application.ThreadException += new ThreadExceptionEventHandler(ThreadExceptionHandler);
                AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(GlobalExceptionHandler);
                ApplicationConfiguration.Initialize();


                ServerStatus = GetUseServerSettingsStatus();
                if (GetUseServerSettingsStatus())
                {
                    ApiRun();
                     WebApp.RunAsync();
                }

                Application.Run(MainFrm);
        }

        static void GlobalExceptionHandler(object sender, UnhandledExceptionEventArgs args)
        {
            MessageBox.Show("An error occurred, and the application will be restarted later. You can submit the log file to the \"Issues\" section on GitHub.");
            WriteLog((Exception)args.ExceptionObject);

        }
        static void ThreadExceptionHandler
        (object sender, System.Threading.ThreadExceptionEventArgs e)
        {

            MessageBox.Show("An error occurred, and the application will be restarted later. You can submit the log file to the \"Issues\" section on GitHub.");
            WriteLog(e.Exception);

        }
        public static void WriteLog(Exception? exception)
        {
            if (exception == null) return;

            var �d = Guid.NewGuid();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "LOGS");
            if (!Directory.Exists(path))
                Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "LOGS"));

            var filePath = Path.Combine(path, $"{�d}.txt");

            var data = exception.Source;
            data += Environment.NewLine + "--------------------";
            data += Environment.NewLine + exception.Message;
            data += Environment.NewLine + "--------------------";
            data += Environment.NewLine + exception.StackTrace;
            data += Environment.NewLine + "--------------------";

            File.WriteAllText(filePath, data);


        }
        public static void ApiRun()
        {
            var builder = WebApplication.CreateBuilder();

            builder.WebHost.UseUrls("http://localhost:5003");

            builder.Services.AddCors(x =>
            {
                x.AddPolicy("allowAll", b =>
                {
                    b.AllowAnyOrigin();
                    b.AllowAnyHeader();
                    b.AllowAnyMethod();
                });
            });
            builder.Services.AddControllers();
            WebApp = builder.Build();


            WebApp.UseCors("allowAll");
            WebApp.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

        }
        public static bool GetUseServerSettingsStatus()
        {
            if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "user.txt")))
            {
                using var stream = (File.Create(Path.Combine(Directory.GetCurrentDirectory(), "user.txt")));

                StreamWriter writer = new StreamWriter(stream);

                writer.Write("server:0");

                writer.Close();
                writer.Dispose();
            }

            var data = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "user.txt"));

            return int.Parse(data.Split(":")[1]) > 0;


        }
    }
}