﻿using Banking.Domain;

namespace Banking.UnitTests.BusinessClock;
public class StandardBusinessClockTests
{
    [Fact]
    public void DuringBusinessHoursReturnsTrue()
    {
        var stubbedClock = new Mock<ISystemTime>();
        stubbedClock.Setup(c => c.GetCurrent()).Returns(new DateTime(1969, 04, 20, 9, 00, 01));
        IProvideTheBusinessClock clock = new StandardBusinessClock(stubbedClock.Object);

        Assert.True(clock.IsDuringBusinessHours());
    }

    [Fact]
    public void AfterBusinessHoursReturnsTrue()
    {
        var stubbedClock = new Mock<ISystemTime>();
        stubbedClock.Setup(c => c.GetCurrent()).Returns(new DateTime(1969, 04, 20, 16, 00, 00));
        IProvideTheBusinessClock clock = new StandardBusinessClock(stubbedClock.Object);

        Assert.False(clock.IsDuringBusinessHours());
    }
}
