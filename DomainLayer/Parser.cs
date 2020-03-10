using DomainLayer.Models;
using InfrastructureLayer.Exceptions;
using Microsoft.Win32;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Safari;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace InfrastructureLayer
{
    public class Parser
    {
        private IWebDriver driver;
        private string root = "http://www.thesoccerworldcups.com/world_cups.php";
        private Random random;
        public Parser()
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Clients\StartMenuInternet");
            var browsers = key.GetSubKeyNames();
            var currentDirectory = Directory.GetCurrentDirectory();
            int lastInd = currentDirectory.LastIndexOf("TopGunLab_Practice1") + 20;

            if (browsers.Length != 0)
            {

                driver = (browsers[0]) switch
                {


                    "Google Chrome" => new ChromeDriver(currentDirectory[0..lastInd] + @"DomainLayer\Drivers\"),
                    "Safari" => new SafariDriver(),
                    _ => new InternetExplorerDriver(),
                };
                driver.Url = root;
                random = new Random();

            }
            else
            {
                throw new BrowserNotDefined("Local Machine doesn't found browser");
            }
        }
        private Coach GetCoach(string values)
        {

            Coach coach = new Coach(values[7..], random.NextDouble() % 10);
            return coach;
        }
        private Player GetPlayer(string values)
        {
            int jersey = random.Next(1, 100);
            int skill = random.Next(1, 100);
            double lucky = random.NextDouble() % 10;
           // string playerName = RegExp.Find(@"(\D+ \D+)", values);
            return null;

        }

        public Team GetTeam()
        {

            //Get all tournaments
            var links = driver.FindElements(By.XPath(@".//div[@class='a-center']//a"));
            int randomNumber = random.Next(0, links.Count);
            driver.Navigate().GoToUrl(links[randomNumber].GetAttribute("href"));

            //Get all team links in current championship
            links = driver.FindElements(By.XPath(@".//div[@class='rd-50-25']//a"));
            randomNumber = random.Next(0, links.Count);
            driver.Navigate().GoToUrl(links[randomNumber].GetAttribute("href"));
            var players = driver.FindElements(By.XPath(@".//table[@class='a-left color-alt']//tbody//tr"));

            //Get coach
            Coach coach = GetCoach(players[players.Count - 1].Text);
            //Get team name
            var teamName = driver.FindElement(By.XPath(@".//div[@class='rd-100-33 a-center margen-t3']")).Text;
            Team team = new Team(teamName, coach);
            return team;
        }

    }
}
