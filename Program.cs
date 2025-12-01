using Stocky.Forms;
using Stocky.Services;

namespace Stocky
{
    internal static class Program
    {
        public static CategoryService CategoryService { get; private set; } = null!;
        public static ProductService ProductService { get; private set; } = null!;
        public static EntryService EntryService { get; private set; } = null!;
        public static ExitService ExitService { get; private set; } = null!;
        public static UserService UserService { get; private set; } = null!;

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            InitializeServices();
            Application.Run(new LoginForm());
        }

        private static void InitializeServices()
        {
            CategoryService = new CategoryService();
            ProductService = new ProductService(CategoryService);
            EntryService = new EntryService(ProductService);
            ExitService = new ExitService(ProductService);
            UserService = new UserService();

            SeedDemoData();
        }

        private static void SeedDemoData()
        {
            var defaultCat = CategoryService.Register("General");
            var toolsCat = CategoryService.Register("Tools");

            UserService.Register("admin@company", "admin", Models.Role.Admin);
            UserService.Register("user@company", "user", Models.Role.User);

            var admin = UserService.Login("admin@company", "admin");
            ProductService.Register(admin!, "Screwdriver", "Flat head screwdriver", 1, 100, 20, "A1", 7.50m, defaultCat.Id);
            ProductService.Register(admin!, "Hammer", "Claw hammer", 1, 50, 10, "A2", 12.00m, toolsCat.Id);
        }
    }
}