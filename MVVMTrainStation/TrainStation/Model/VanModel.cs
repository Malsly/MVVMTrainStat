﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainStation.Model
{
    public class VanModel 
    {
        private List<SeatModel> seatList { get; set; }
        private string classVan { get; set; }
        private int number { get; set; }
        private static Dictionary<string, int> classAndPrice = new Dictionary<string, int>();


        public static Dictionary<string, int> ClassAndPrice  // property
        {
            get { return classAndPrice; }   // get method
        }

        public List<SeatModel> SeatList   // property
        {
            get { return seatList; }   // get method
            set { seatList = value; }
        }

        public string Class   // property
        {
            get { return classVan; }   // get method
            set { classVan = value; }
        }

        public int Number   // property
        {
            get { return number; }   // get method
            set { number = value; }
        }

        public VanModel(List<SeatModel> SeatList, string Class, int Number)
        {
            this.SeatList = SeatList;
            this.Class = Class;
            this.Number = Number;
        }

        public SeatModel PickSeat(int Number, string Type)
        {
            SeatModel pickedSeat = SeatList.FirstOrDefault(i => i.Number == Number && i.Type == Type && !i.IsOccuped);
            return pickedSeat;
        }

        public void CreateSeatForVan(int countOfSeats, string type)
        {
            int lastNumberOfSeat = 0;
            if (seatList.Count != 0) lastNumberOfSeat = seatList[seatList.Count - 1].Number + 1;
            for (int i = lastNumberOfSeat; i < lastNumberOfSeat + countOfSeats; i++)
            {
                AddSeat(i, type, false);
            }
        }

        public void AddSeat(int number, string type, bool isOccuped)
        {
            seatList.Add(new SeatModel(number, type, isOccuped));
        }

        public static void AddClassAndPrice(string classValue, int price)
        {
            classAndPrice.Add(classValue, price);
        }
    }
}
