﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Dietpolix.Views
{
    public interface IRegisterScreen
    {
        event Action<object, EventArgs> VEvent_OnRegister;
        event Action<object, EventArgs> VEvent_OnGotoLogin;

        void ShowInfo();
        List<TextBox> ListOfTextboxes();
        ErrorProvider GiveErrorProvider();

        string Login { get; set; }
        string Name { get; set; }
        string Password1 { get; set; }
        string Password2 { get; set; }

        Control FormDietpolix { get; }
        FormDietpolix parent { get; }
    }
}
