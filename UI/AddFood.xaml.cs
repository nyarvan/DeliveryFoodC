using API;
using System;
using System.Windows;


namespace UI
{
    public partial class AddFood : Window
    {
        private readonly IController<FoodModel> FoodController;
        private readonly FoodModel food;
        public AddFood(FoodModel food, IController<FoodModel> FoodController)
        {
            this.FoodController = FoodController;
            this.food = food;
            InitializeComponent();
            if(food != null)
            {
                AddFoodButton.Visibility = Visibility.Hidden;
                AddFoodButton.IsEnabled = false;
                ButtonUpdate.Visibility = Visibility.Visible;
                ButtonUpdate.IsEnabled = true;
                NameBox.Text = food.Name;
                PriceBox.Text = food.Price.ToString();
            }
        }

        private void AddFoodButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FoodModel food = new FoodModel()
                {
                    Name = NameBox.Text,
                    Price = Double.Parse(PriceBox.Text)
                };

                FoodController.Add(food);
                MessageBox.Show("Нову страву додано");
                Close();
            }
            catch(Exception) { MessageBox.Show("Помилка!"); }
            
        }

        private void ButtonUpdate_Click(object sender, RoutedEventArgs e)
        {
            if(food != null)
            {
                try
                {
                    food.Name = NameBox.Text;
                    food.Price = Double.Parse(PriceBox.Text);
                    FoodController.Update(food);
                    Close();
                    MessageBox.Show("Дані страви оновлені!");
                }
                catch(Exception) { MessageBox.Show("Помилка!"); }
            }
        }
    }
}
