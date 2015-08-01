using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Domain.Products;
using Persistence.UnitOfWork;

namespace ProductTransfer
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
        }
        //public MainWindow(IUnitOfWorkHelper _unitOfWorkHelper)
        //{

        //    InitializeComponent();
        //}

        private IUnitOfWorkHelper _unitOfWorkHelper;

        public IUnitOfWorkHelper UnitOfWorkHelper
        {
            get { return _unitOfWorkHelper ?? new UnitOfWorkHelper(); }
            private set { _unitOfWorkHelper = value; }
        }


        private void button_Click(object sender, RoutedEventArgs e)
        {
            var product = new ProductStore
            {
                Name = textBox.Text,
                Description = textBox_Copy.Text,
                MeasureUnit = textBox_Copy1.Text,
                Codigo = textBox_Copy2.Text
            };
            try
            {
                UnitOfWorkHelper.DbContext.Products.Add(product);
                UnitOfWorkHelper.DbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                var mensaje = ex.Message;
                
                throw;
            }
          

        }
    }
}
