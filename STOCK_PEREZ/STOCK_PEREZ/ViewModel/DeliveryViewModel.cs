using MvvmHelpers;
using STOCK_PEREZ.Models;
using System;
using System.Collections.Generic;
using System.Text;
namespace STOCK_PEREZ.ViewModel
{
    public class DeliveryViewModel : BaseViewModel
    {
        public ObservableRangeCollection<DeliveryModel> items;
        public ObservableRangeCollection<DeliveryModel> Delivers
        {
            get => items;
            set => SetProperty(ref items, value);
        }

        public DeliveryViewModel()
        {
            items = new ObservableRangeCollection<DeliveryModel> {
                new DeliveryModel{
                   reference = 2455416552783,
                        Date = DateTime.Now.ToString("f"),
                        PlaceOfDelivery = "Bonamoussadi",
                        User = new UserModel(68319752,"Marcus")

                 }, new DeliveryModel{
                     reference = 2455416552783,
                        Date = DateTime.Now.ToString("f"),
                        PlaceOfDelivery = "Bonamoussadi",
                        User = new UserModel(68319752,"Karl")

                 }, new DeliveryModel{
                      reference = 675871432683,
                        Date = DateTime.Now.ToString("f"),
                        PlaceOfDelivery = "Bepanda",
                        User = new UserModel(683195594,"Kambell")

                 }, new DeliveryModel{
                      reference = 325416752783,
                        Date = DateTime.Now.ToString("f"),
                        PlaceOfDelivery = "Akwa",
                        User = new UserModel(683195594,"Billy")

                 }, new DeliveryModel{
                      reference = 325416752783,
                        Date = DateTime.Now.ToString("f"),
                        PlaceOfDelivery = "Akwa",
                        User = new UserModel(683195594,"Billy")

                 }, new DeliveryModel{
                       reference = 5416097127163,
                        Date = DateTime.Now.ToString("f"),
                        PlaceOfDelivery = "Bonaberi",
                        User = new UserModel(686515273,"Joyce")

                 }, new DeliveryModel{
                      reference = 325416752783,
                        Date = DateTime.Now.ToString("f"),
                        PlaceOfDelivery = "Akwa",
                        User = new UserModel(683195594,"Billy")

                 }, new DeliveryModel{
                      reference = 325416752783,
                        Date = DateTime.Now.ToString("f"),
                        PlaceOfDelivery = "Akwa",
                        User = new UserModel(683195594,"Billy")

                 }
            };
        }

        /*
                public ObservableRangeCollection<DeliveryModel> items;

                public ObservableRangeCollection<DeliveryModel> Deliverys
                {
                    get => items;
                    set => SetProperty(ref items, value);
                }
                public MainPage()
                {
                    InitializeComponent();

                    Deliverys = new List<DeliveryModel>();

                    Deliverys.Add(new DeliveryModel
                    {
                        reference = 325416752783,
                        Date = DateTime.Now.ToString("f"),
                        PlaceOfDelivery = "Akwa",
                        User = new UserModel(683195594,"Billy")
                    });

                    Deliverys.Add(new DeliveryModel
                    {
                        reference = 2455416552783,
                        Date = DateTime.Now.ToString("f"),
                        PlaceOfDelivery = "Bonamoussadi",
                        User = new UserModel(68319752,"Karl")
                    }); 

                    Deliverys.Add(new DeliveryModel
                    {
                        reference = 675871432683,
                        Date = DateTime.Now.ToString("f"),
                        PlaceOfDelivery = "Bepanda",
                        User = new UserModel(683195594,"Kambell")
                    }); 

                    Deliverys.Add(new DeliveryModel
                    {
                        reference = 5416097127163,
                        Date = DateTime.Now.ToString("f"),
                        PlaceOfDelivery = "Bonaberi",
                        User = new UserModel(686515273,"Joyce")
                    });

                    Deliverys.Add(new DeliveryModel
                    {
                        reference = 325416752783,
                        Date = DateTime.Now.ToString("f"),
                        PlaceOfDelivery = "Akwa",
                        User = new UserModel(683195594,"Billy")
                    });

                    Deliverys.Add(new DeliveryModel
                    {
                        reference = 325416752783,
                        Date = DateTime.Now.ToString("f"),
                        PlaceOfDelivery = "Akwa",
                        User = new UserModel(683195594,"Billy")
                    }); Deliverys.Add(new DeliveryModel
                    {
                        reference = 325416752783,
                        Date = DateTime.Now.ToString("f"),
                        PlaceOfDelivery = "Akwa",
                        User = new UserModel(683195594,"Billy")
                    }); Deliverys.Add(new DeliveryModel
                    {
                        reference = 325416752783,
                        Date = DateTime.Now.ToString("f"),
                        PlaceOfDelivery = "Akwa",
                        User = new UserModel(683195594,"Billy")
                    }); Deliverys.Add(new DeliveryModel
                    {
                        reference = 325416752783,
                        Date = DateTime.Now.ToString("f"),
                        PlaceOfDelivery = "Akwa",
                        User = new UserModel(683195594,"Billy")
                    });

                    BindingContext = this;
        */
    }
}
