using API;
using System.Windows;

namespace UI
{

    public partial class ManagerMenu : Window
    {
        private readonly IController<FoodModel> FoodController;
        private readonly IController<SetModel> SetController;
        public ManagerMenu(IController<FoodModel> FoodController, IController<SetModel> SetController)
        {
            this.FoodController = FoodController;
            this.SetController = SetController;
            InitializeComponent();
            LoadDG();
        }

        void LoadDG()
        {
            FoodsDataGrid.ItemsSource = FoodController.GetAll();
            SetsDataGrid.ItemsSource = SetController.GetAll();
        }

        private void ButtonAddFood_Click(object sender, RoutedEventArgs e)
        {
            AddFood food_menu = new AddFood(null, FoodController);
            food_menu.ShowDialog();
        }

        private void ButtonDeleteFood_Click(object sender, RoutedEventArgs e)
        {
            FoodController.Remove(((FoodModel)FoodsDataGrid.SelectedItem).Id);
            FoodController.Save();
            LoadDG();
        }

        private void FoodsDataGrid_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            AddFood update_food = new AddFood((FoodModel)FoodsDataGrid.SelectedItem, FoodController);
            update_food.ShowDialog();
        }

        private void ButtonAddSet_Click(object sender, RoutedEventArgs e)
        {
            AddSet addSet = new AddSet(null, FoodController, SetController);
            addSet.ShowDialog();
        }

        private void ButtonDeleteSet_Click(object sender, RoutedEventArgs e)
        {
            SetController.Remove(((SetModel)SetsDataGrid.SelectedItem).Id);
            SetController.Save();
            LoadDG();
        }

        private void SetsDataGrid_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            AddSet update_set = new AddSet((SetModel)SetsDataGrid.SelectedItem, FoodController, SetController);
            update_set.ShowDialog();
        }

        private void ButtonRefresh_Click(object sender, RoutedEventArgs e)
        {
            LoadDG();
        }
    }
}
