using System;
using System.Collections.Generic;
using System.Windows;
using API;

namespace UI
{
    public partial class MainWindow : Window
    {
        private readonly IController<DeliveryModel> DeliveryController;
        private readonly IController<FoodModel> FoodController;
        private readonly IController<SetModel> SetController;

        public MainWindow(IController<DeliveryModel> DeliveryController, IController<FoodModel> FoodController, IController<SetModel> SetController)
        {
            this.DeliveryController = DeliveryController;
            this.FoodController = FoodController;
            this.SetController = SetController;
            InitializeComponent();
            LoadDG();
        }

        void LoadDG()
        {
            DeliveryDataGrid.ItemsSource = DeliveryController.GetAll();
        }
  
        private void Update_DG(object sender, EventArgs e)
        {
            LoadDG();
        }

        private void ButtonAddDelivery_Click(object sender, RoutedEventArgs e)
        {
            AddDelivery DeliveryWindow = new AddDelivery(null, DeliveryController, FoodController, SetController);
            DeliveryWindow.Closed += Update_DG;
            DeliveryWindow.ShowDialog();
        }

        private void DeleteDeliveryButton_Click(object sender, RoutedEventArgs e)
        {
            DeliveryController.Remove(((DeliveryModel)DeliveryDataGrid.SelectedItem).Id);
            DeliveryController.Save();
            LoadDG();
        }

        private void ButtonManager_Click(object sender, RoutedEventArgs e)
        {
            ManagerMenu manager = new ManagerMenu(FoodController, SetController);
            manager.ShowDialog();
        }

        private void DeliveryDataGrid_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            AddDelivery editDelibery = new AddDelivery((DeliveryModel)DeliveryDataGrid.SelectedItem, DeliveryController, FoodController, SetController);
            editDelibery.ShowDialog();
        }

        private void DeliveryDataGrid_PreparingCellForEdit(object sender, System.Windows.Controls.DataGridPreparingCellForEditEventArgs e)
        {
            string list = "";


            List<FoodModel> Foods = ((DeliveryModel)DeliveryDataGrid.SelectedItem).Foods;
            List<SetModel> Sets = ((DeliveryModel)DeliveryDataGrid.SelectedItem).Sets;

            foreach (FoodModel food in Foods)
            {
                list += food.Name + ", ";
            }

            foreach (SetModel set in Sets)
            {
                list += set.Name + ", ";
            }

            ListFood.Text = list;
        }
    }
}
