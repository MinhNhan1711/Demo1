using System;
using System.Collections.Generic;
using System.Text;

namespace Lap2_LeTruongMinhNhan_Bai34
{
    interface IAccount
    {
        string Account_ID
        {
            get ; 
            set ; 
        }

        string FirstName
        { 
            get ; 
            set ; 
        }

        string LastName
        {
            get ; 
            set ; 
        }

        string Balance
        {
            get ; 
            set ; 
        }
        void Show();
    }
}
