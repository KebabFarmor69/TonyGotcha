using System.Collections.Generic;
using System;

namespace TonyGotcha
{
    public class Tony
    {
        private int hunger;
        private int boredom;
        private List<string> words = new List<string>();
        private bool isAlive;
        private Random generator = new Random();
        public string name;
        public void Feed()
        {
            hunger--;
        }
        public void Hi()
        {
            int i = generator.Next(words.Count);
            System.Console.WriteLine(words[i]);
        }
        public void Teach(string word)
        {
            words.Add(word);
        }
        public void Tick()
        {
            hunger++;
            boredom++;

            if (hunger < 10 && boredom < 10)
            {
                isAlive = false;
            }
        }
        public void PrintStats()
        {

        }
        public bool GetAlive()
        {
            return isAlive;
        }
        private void ReduceBoredom()
        {

        }
    }
}