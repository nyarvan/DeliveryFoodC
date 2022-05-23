using API;
using System.Windows;
using System;
using System.Collections.Generic;


namespace UI
{
    public partial class AddSet : Window
    {
        private readonly IController<FoodModel> FoodController;
        private readonly IController<SetModel> SetController;
        SetModel set;
        List<FoodModel> foods;
        
        public AddSet(SetModel set, IController<FoodModel> FoodController, IController<SetModel> SetController)
        {
            this.FoodController = FoodController;
            this.SetController = SetController;
            this.set = set;
            InitializeComponent();
            LoadDG();
            if (set != null)
            {
                ButtonAdd.Visibility = Visibility.Hidden;
                ButtonAdd.IsEnabled = false;
                ButtonUpdate.Visibility = Visibility.Visible;
                ButtonUpdate.IsEnabled = true;
                NameBox.Text = set.Name;
                foreach(FoodModel food in set.foods)
                {
                    ListFood.Items.Add(food.Name);
                }

                foods = set.foods;
            }
            foods = new List<FoodModel>();
        }

        void LoadDG()
        {
            FoodsDataGrid.ItemsSource = FoodController.GetAll();
        }
        private void ButtonUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (set != null)
            {
                try
                {
                    set.Name = NameBox.Text;
                    set.foods = foods;
                    SetController.Update(set);
                    MessageBox.Show("Оновлен комплекс!");
                    Close();
                }
                catch(Exception) { MessageBox.Show("Помилка!"); }
            }
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SetModel set = new SetModel()
                {
                    Name = NameBox.Text,
                    foods = foods
                };
                SetController.Add(set);
                MessageBox.Show("Додан новий комплекс!");
                Close();
            }
            catch(Exception) { MessageBox.Show("Помилка!"); }
        }

        private void FoodsDataGrid_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ListFood.Items.Add(((FoodModel)FoodsDataGrid.SelectedItem).Name);
            foods.Add((FoodModel)FoodsDataGrid.SelectedItem);
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            ListFood.Items.Remove(ListFood.SelectedItem);
            foods.Remove((FoodModel)ListFood.SelectedItem);
        }
    }
}
