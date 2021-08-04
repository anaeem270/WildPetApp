﻿using System;
using System.Collections.Generic;
using System.Text;

namespace The_Wild_Vet.Models
{
    public enum MenuItemType
    {
        Pets,
        Appointments,
        AddAPet,
        Support,
        Settings,
        Profile,
        About,
        Logout
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
    }
}
