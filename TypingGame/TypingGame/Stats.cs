// Copyright © 2012 Herick Oliveira <mailto:hkmarques@gmail.com>
// 
// This file is part of TypingGame.
// TypingGame is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// TypingGame is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// See <http://www.gnu.org/licenses/> if no copy of the GNU General 
// Public License was made available along with this copy of TypingGame.

namespace TypingGame
{
    /// <summary>
    /// 
    /// </summary>
    public class Stats
    {
        public int Total;

        public int Missed;

        public int Correct;

        public int Accuracy;

        public void Update(bool correctKey)
        {
            Total++;

            if (!correctKey)
            {
                Missed++;
            }
            else
            {
                Correct++;
            }

            Accuracy = 100 * Correct / (Correct + Missed);
        }

        public void Reset()
        {
            Total = 0;
            Missed = 0;
            Correct = 0;
            Accuracy = 0;
        }
    }
}
