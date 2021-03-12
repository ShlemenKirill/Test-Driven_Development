using LandonHotel.Data;
using LandonHotel.Services;
using System;
using Xunit;

namespace LandonHotel.Tests
{
    public class BookingServiceTests
    {
        [Fact]
        public void IsBookingVAlid_NoSmoker_Valid()
        {
            var service = new BookingService(null, null);
            var IsValid = service.IsBookingValid(1, new Booking()
            {
                IsSmoking = false
            });

            Assert.True(IsValid);
        }

        [Fact]
        public void IsBookingVAlid_Smoker_InValid()
        {
            var service = new BookingService(null, null);
            var IsValid = service.IsBookingValid(1, new Booking()
            {
                IsSmoking = true
            });

            Assert.False(IsValid);
        }
    }
}
