﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EagleEye
{
    internal class MenuManager
    {
        private AgentDAL _dal = AgentDAL.GetDAL();
        private static MenuManager _instance;
        private MenuManager() { }
        public static MenuManager GetMenuManager()
        {
            if (_instance is null)
            {
                _instance = new MenuManager();
            }
            return _instance;
        }
        public void ShowAgent(Agent agent)
        {
            Console.WriteLine(
                   $"ID: {agent.ID}. " +
                   $"CodeName: {agent.CodeName}. " +
                   $"RealName: {agent.RealName}. " +
                   $"Location: {agent.Location}. " +
                   $"Status: {agent.Status}. " +
                   $"MissionCompleted: {(agent.MissionCompleted == 0 ? "Not Completed" : "Completed")}");
        }
        private void ShowAgents(List<Agent> agents)
        {
            foreach (Agent agent in agents)
            {
                Console.WriteLine(
                    $"ID: {agent.ID}. " +
                    $"CodeName: {agent.CodeName}. " +
                    $"RealName: {agent.RealName}. " +
                    $"Location: {agent.Location}. " +
                    $"Status: {agent.Status}. " +
                    $"MissionCompleted: {(agent.MissionCompleted == 0 ? "Not Completed" : "Completed")}");
            }
        }
        private void ShowMenu()
        {
            Console.WriteLine(
                "--Eagle Eye Database--\n" +
                "Options:\n" +
                "1. Add agent.\n" +
                "2. Show all agents.\n" +
                "3. Update agent location.\n" +
                "4. Update agent status.\n" +
                "5. Delete agent.\n" +
                "6. Exit.");
        }
        private string GetSelection()
        {
            Console.WriteLine("Enter your selection:");
            return Console.ReadLine();
        }
        private bool Validate(string selection)
        {
            string[] validated = { "1", "2", "3", "4", "5" };
            return validated.Contains(selection);
        }
        private void ExecuteSelection(string selection)
        {
            switch (selection)
            {
                case "1":
                    Console.WriteLine("Not possible yet.");
                    break;
                case "2":
                    this.ShowAgents(this._dal.GetAgents());
                    break;
                case "3":
                    Console.WriteLine("Not possible yet.");
                    break;
                case "4":
                    Console.WriteLine("Not possible yet.");
                    break;
                case "5":
                    Console.WriteLine("Not possible yet.");
                    break;
            }
        }
        public void ManipulateData()
        {
            bool toExit = false;
            string exit = "6";
            while (!toExit)
            {
                this.ShowMenu();
                string selection = this.GetSelection();
                if (selection == exit)
                {
                    toExit = true;
                    continue;
                }
                bool validated = this.Validate(selection);
                if (!validated)
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }
                this.ExecuteSelection(selection);
            }
        }
    }
}
