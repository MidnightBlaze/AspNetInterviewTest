﻿using ASPTest.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPTest
{
    public class EventsRepository : IEvents
    {
        IData _DataRepository = new DataRepository();
        List<int> Items = new List<int>();
        Random _rand = new Random();
        public EventsRepository()
        {
           
            for (int i = 0; i < 100; i++)
            {
                Items.Add(_rand.Next(0, 100));
            }

            _DataRepository.SaveItems(Items);
        }

        public int Next(int Postion)
        {
            return 0;
        }

        public List<int> GetAllItems()
        {
            return Items;
        }
    }

    interface IEvents
    {
        int Next(int Postion);
        List<int> GetAllItems();

    }
}