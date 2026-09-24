using System.Collections.Generic;
using Ucu.Poo.Discord;

namespace Ucu.Poo.RideShare
{
    public class UcuRideShare
    {
        private List<Driver> drivers = new List<Driver>();
        private List<Passenger> passengers = new List<Passenger>();
        private DiscordClient discord;
        private ulong channelId;

        public UcuRideShare(DiscordClient discord, ulong channelId)
        {
            this.discord = discord;
            this.channelId = channelId;
        }

        public void Add(Driver driver)
        {
            this.drivers.Add(driver);

            this.discord.SendMessage(
                this.channelId,
                driver.Welcome());

            this.discord.SendImage(
                this.channelId,
                driver.Photo,
                driver.Bio);
        }

        public void Add(Passenger passenger)
        {
            this.passengers.Add(passenger);

            this.discord.SendImage(
                this.channelId,
                passenger.Photo,
                passenger.Welcome());
        }
    }
}