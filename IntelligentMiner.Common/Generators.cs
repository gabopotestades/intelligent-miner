﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IntelligentMiner.Common
{
    public class Generators
    {
        private List<(string, string)> situations = new List<(string, string)>();

        public List<(string, string)> Situations
        {
            get { return situations; }
            set { situations = value; }
        }

        private IDictionary<string, string> moves = new Dictionary<string, string>()
        {
            {"0", "Rotate"},
            {"1", "Move Forward"}
        };

        public IDictionary<string, string> Moves
        {
            get { return moves; }
            set { moves = value; }
        }

        private List<string> strategies = new List<string>();

        public List<string> Strategies
        {
            get { return strategies; }
            set { strategies = value; }
        }

        public void GeneratePossibilities()
        {
            string[] possibleStates = {"Empty", "Wall", "Beacon", "Trap", "Square"};

            foreach (string state in possibleStates)
            {
                foreach (string state2 in possibleStates)
                {
                    situations.Add((state, state2));
                }
            }
        }

        public void GenerateStrategies()
        {
            //Generate 200 Strategies
            var random = new Random();
            int population = 200;
            for (int i = 0; i < population; i++)
            {
                //Generate moves based on strategies
                string strat = "";

                for (int j = 0; j < 25; j++)
                {
                    strat = String.Concat(strat, random.Next(0, 2));
                }

                strategies.Add(strat);
            }

        }

    }
}
