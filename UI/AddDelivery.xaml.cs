using System;
using System.Collections.Generic;
using System.Windows;
using API;

namespace UI
{
 
    public partial class AddDelivery : Window
    {
        private readonly IController<DeliveryModel> DeliveryController;
        private readonly IController<FoodModel> FoodController;
        private readonly IController<SetModel> SetController;
        List<FoodModel> foods;
        List<SetModel> sets;
        DeliveryModel delivery;

        public AddDelivery(DeliveryModel model, IController<DeliveryModel> DeliveryController, IController<FoodModel> FoodController, IController<SetModel> SetController)
        {
            this.delivery = model;
            this.DeliveryController = DeliveryController;
            this.FoodController = FoodController;
            this.SetController = SetController;
            InitializeComponent();
            LoadDG();
            if(model != null)
            {
                ButtonAddDelivery.Visibility = Visibility.Hidden;
                ButtonAddDelivery.IsEnabled = true;
                ButtonUpdate.Visibility = Visibility.Visible;
                ButtonUpdate.IsEnabled = true;
                NameBox.Text = model.Name;
                PhoneBox.Text = model.Phone;
                DateDelivery.SelectedDate = model.DeliveryTime;
                HourBox.Text = model.DeliveryTime.Hour.ToString();
                MinutesBox.Text = model.DeliveryTime.Minute.ToString();
                foods = model.Foods;
                sets = model.Sets;
                foreach (FoodModel food in foods)
                {
                    ListFood.Items.Add(food.Name);
                }
                foreach(SetModel set in sets)
                {
                    ListFood.Items.Add(set.Name);
                }
                
            }
            foods = new List<FoodModel>();
            sets = new List<SetModel>();
        }

        void LoadDG()
        {
            FoodDataGrid.ItemsSource = FoodController.GetAll();
            SetDataGrid.ItemsSource = SetController.GetAll();
        }

        private void FoodDataGrid_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
            ListFood.Items.Add(((FoodModel)FoodDataGrid.SelectedItem).Name);
            foods.Add((FoodModel)FoodDataGrid.SelectedItem);
        }

        private void SetDataGrid_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ListFood.Items.Add(((SetModel)SetDataGrid.SelectedItem).Name);
            sets.Add((SetModel)SetDataGrid.SelectedItem);
        }

        private void DeleteFoodButton_Click(object sender, RoutedEventArgs e)
        {
            ListFood.Items.Remove(ListFood.SelectedItem);
            if(foods.Contains((FoodModel)ListFood.SelectedItem))
            {
                foods.Remove((FoodModel)ListFood.SelectedItem);

            }
            else if (sets.Contains((SetModel)ListFood.SelectedItem))
            {
                sets.Remove((SetModel)ListFood.SelectedItem);
            }
        }

        private void ButtonAddDelivery_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                DeliveryModel delivery = new DeliveryModel()
                {
                    Name = NameBox.Text,
                    Phone = PhoneBox.Text,
                    DeliveryTime = new DateTime(DateDelivery.SelectedDate.Value.Year, DateDelivery.SelectedDate.Value.Month, DateDelivery.SelectedDate.Value.Day, Int32.Parse(HourBox.Text), Int32.Parse(MinutesBox.Text), 0),
                    Foods = foods,
                    Sets = sets
                };

                DeliveryController.Add(delivery);
                MessageBox.Show("Нове замовлення додано");
                Close();
            }
            catch (Exception) { MessageBox.Show("Помилка!"); }
               
        }

        private void ButtonUpdate_Click(object sender, RoutedEventArgs e)
        {
            if(delivery != null)
            {
                try
                {
                    delivery.Name = NameBox.Text;
                    delivery.Phone = PhoneBox.Text;
                    delivery.DeliveryTime = new DateTime(DateDelivery.SelectedDate.Value.Year, DateDelivery.SelectedDate.Value.Month, DateDelivery.SelectedDate.Value.Day, Int32.Parse(HourBox.Text), Int32.Parse(MinutesBox.Text), 0);
                    delivery.Foods = foods;
                    delivery.Sets = sets;
                    DeliveryController.Save();
                    MessageBox.Show("Зміна замовлення прошла успішно!");
                }
                catch (Exception) { MessageBox.Show("Помилка!"); }
            }
        }

        
        
    }
}
