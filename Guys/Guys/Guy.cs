// Copyright © 2012 Herick Oliveira <mailto:hkmarques@gmail.com>
// 
// This file is part of Guys.
// Guys is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// Guys is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// See <http://www.gnu.org/licenses/> if no copy of the GNU General 
// Public License was made available along with this copy of Guys.

using System.Windows.Forms;

namespace Guys
{
    /// <summary>
    /// 
    /// </summary>
    public class Guy
    {
        public string Name;

        public int Cash;
        
        public int GiveCash(int amount)
        {
            if (amount <= Cash && amount > 0)
            {
                Cash -= amount;
                return amount;
            }
            else
            {
                MessageBox.Show("I don't have enough cash to give you " + amount, Name + " says...");
                return 0;
            }
        }

        public int ReceiveCash(int amount)
        {
            if (amount > 0)
            {
                Cash += amount;
                return amount;
            }
            else
            {
                MessageBox.Show(amount + " isn't an amount I'll take", Name + " says...");
                return 0;
            }
        }
    }
}
