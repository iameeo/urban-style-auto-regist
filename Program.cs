using Microsoft.Extensions.DependencyInjection;
using urban_style_auto_regist;

namespace urban_style_auto_regist
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);  // ���� ���
            var serviceProvider = services.BuildServiceProvider();

            var mainForm = serviceProvider.GetRequiredService<Form1>();
            Application.Run(mainForm);
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            // DbContext ��� (���� ���ڿ��� AppDbContext���� �����ϹǷ� ���⼭ ����)
            services.AddDbContext<AppDbContext>();

            // Form1�� transient�� ���
            services.AddTransient<Form1>();
        }
    }
}
