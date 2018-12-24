using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_04_01.ViewModels;

namespace Xamarin_04_01.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StudentView : ContentPage
    {
       

        public StudentView()
        {
            InitializeComponent();         
            this.BindingContext = new StudentsViewModel();
        }

    }
}