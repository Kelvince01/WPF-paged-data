using PagedData.Services;
using PagedData.ViewModels;
using Unity;

namespace PagedData.Utilities
{
    public class ViewModelLocator
    {
        private readonly UnityContainer container;

        public ViewModelLocator()
        {
            container = new UnityContainer();
            container.RegisterType<IEmployeesService, EmployeesService>();
        }

        public MainWindowViewModel MainWindowVM => container.Resolve<MainWindowViewModel>();
    }
}