using Forsaj.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace Forsaj.Views
{
    /// <summary>
    /// Логика взаимодействия для Clients.xaml
    /// </summary>
    public partial class Clients : Page
    {
        public Clients()
        {
            InitializeComponent();
            LoadClientsToGrid();
            using (ForsajFitnessEntities1 userEntity = new ForsajFitnessEntities1())
            {
                cbAbonement.Items.Add("Все типы");
                var categories = userEntity.Abonements.Select(x => x.abonementType).ToList();
                cbAbonement.SelectedItem = cbAbonement.Items[0];
                foreach (var category in categories)
                {
                    cbAbonement.Items.Add(category);
                }

                var clients = userEntity.Clients.ToList();
                cbSort.Items.Add("Без сортировки");
                cbSort.Items.Add("По возрастанию");
                cbSort.Items.Add("По убыванию");

                cbSort.SelectedItem = cbSort.Items[0];

                countAll = clients.Count();
                lbCountAll.Text = countAll.ToString();

                
            }
            timer.Start();
            timer.Tick += Timer_Tick;
        }
        int countAll, filterAbonements, countCurrent;




        public void LoadClientsToGrid()
        {
            listClients.Items.Clear();
            using (ForsajFitnessEntities1 context = new ForsajFitnessEntities1())
            {
                List<Entity.Clients> clients = context.Clients.ToList();

                // Очистка списка перед добавлением клиентов

                foreach (var client in clients)
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.DataContext = client;
                    listViewItem.Content = new
                    {
                        Name = client.clientName,
                        Surname = client.clientSurname,
                        Patronymic = client.clientPatronymic,
                        CountOfTrainings = client.clientCountOfTrainings,
                        AbonementType = client.Abonements.abonementType,
                        UID = client.clientUID// Вывод типа абонемента
                    };

                    listClients.Items.Add(listViewItem);
                }
            }
        }
        DispatcherTimer timer = new DispatcherTimer();
        public void RefreshList()
        {
            
            using (ForsajFitnessEntities1 context = new ForsajFitnessEntities1())
            {
                List<Entity.Clients> clients = context.Clients.ToList();

                if (clients.Count != listClients.Items.Count)
                {
                    LoadClientsToGrid();
                    countAll = clients.Count();
                    lbCountAll.Text = countAll.ToString();
                    
                }

            }
           
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            RefreshList();
        }
            private void cbAbonement_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            filterAbonements = cbAbonement.SelectedIndex;


        }

        private void DelClients(object sender, RoutedEventArgs e)
        {
            var selectedItem = listClients.SelectedItem as ListViewItem;

            using (ForsajFitnessEntities1 usersEntities = new ForsajFitnessEntities1())
            {
                if (selectedItem != null)
                {
                    var selectedClient = selectedItem.DataContext as Entity.Clients;
                    if (selectedClient != null)
                    {
                        var item = usersEntities.Clients.FirstOrDefault(x => x.clientUID == selectedClient.clientUID);

                        if (item != null)
                        {
                            usersEntities.Clients.Remove(item);
                            usersEntities.SaveChanges();
                        }
                    }
                }
                var clients = usersEntities.Clients.ToList();
                countAll = clients.Count();
                lbCountAll.Text = countAll.ToString();
                listClients.ItemsSource = null;
                LoadClientsToGrid();
            }
        }


        private bool isScanFormOpen = false;
        private Scaning scan;
        private AddClients addClients;
        private void btnScan_Click(object sender, RoutedEventArgs e)
        {

            if (!isScanFormOpen)
            {
                scan = new Scaning();
                scan.Closed += Scaning_Closed; // Добавляем обработчик события Closed
                scan.Show();
                isScanFormOpen = true;
            }

        }
        private void AddClients_Closed(object sender, EventArgs e)
        {
            isScanFormOpen = false;
        }
        private void btnAddClients_Click(object sender, RoutedEventArgs e) //чтобы при открытой форме и нажатии на кнопку открытия этой же формы она не открывалась
        {
            if (!isScanFormOpen)
            {
                addClients = new AddClients();
                addClients.Closed += AddClients_Closed; // Добавляем обработчик события Closed
                addClients.Show();
                isScanFormOpen = true;
            }
        }
        private void Scaning_Closed(object sender, EventArgs e)
        {
            isScanFormOpen = false;
        }

    }
}
