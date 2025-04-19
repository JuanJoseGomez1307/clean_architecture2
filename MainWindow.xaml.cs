using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        void CreateTask()
        {
            Task T;
            var Code = new Action(ShowMesage);
            T = new Task(Code);
            Task T2 = new Task(delegate
            {
                MessageBox.Show("Ejecutando una tarea en un método anónimo.");
            }
            );

            Task T3A = new Task(ShowMesage);
            Task T3 = new Task(
                () => ShowMesage());

            Task T4 = new Task(() => MessageBox.Show("Ejecutando la tarea 4"));

            Task T5 = new Task(() =>
                {
                    DateTime CurrentDate = DateTime.Today;
                    DateTime StarDate = CurrentDate.AddDays(30);
                    MessageBox.Show($"Tarea 5. Fecha Calculada: {StarDate}");
                }   
            );

            Task T6 = new Task((message) =>
            MessageBox.Show(message), "Expresión Lambda con parámetros.");
        }

          


        void ShowMesage()
        {
            MessageBox.Show("Ejecutando el método ShowMessage");
        }

        
}
}