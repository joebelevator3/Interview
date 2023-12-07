using LearningStarter;
using LearningStarter.Entities;
using NUnit.Framework;

namespace UnitTest;

public class MeetingConflictTests
{

    [Test]
    public void Test1()
    {
        var meeting1 = new Meeting
        {
            // 12:00PM - 12:30PM
            StartTime = new DateTime(2022, 01, 01, 12, 0, 0),
            EndTime = new DateTime(2022, 01, 01, 12, 30, 0),
        };
        var meeting2 = new Meeting
        {
            // 12:15PM - 12:45PM
            StartTime = new DateTime(2022, 01, 01, 12, 15, 0),
            EndTime = new DateTime(2022, 01, 01, 12, 45, 0),
        };
        var hasConflict = MeetingConflictResolver.MeetingsConflict(meeting1, meeting2);
        Assert.That(hasConflict);
    }
    
    [Test]
    public void Test2()
    {
        var meeting1 = new Meeting
        {
            // 12:00PM - 1:00PM
            StartTime = new DateTime(2022, 01, 01, 12, 0, 0),
            EndTime = new DateTime(2022, 01, 01, 13, 0, 0),
        };
        var meeting2 = new Meeting
        {
            // 2:15PM - 3:00PM
            StartTime = new DateTime(2022, 01, 01, 2, 15, 0),
            EndTime = new DateTime(2022, 01, 01, 3, 0, 0),
        };
        var hasConflict = MeetingConflictResolver.MeetingsConflict(meeting1, meeting2);
        Assert.That(hasConflict, Is.EqualTo(false));
    }
    
    [Test]
    public void Test3()
    {
        var meeting1 = new Meeting
        {
            // 6:00PM - 7:00PM
            StartTime = new DateTime(2022, 01, 01, 12, 0, 0),
            EndTime = new DateTime(2022, 01, 01, 13, 0, 0),
        };
        var meeting2 = new Meeting
        {
            // 5:00AM - 6:00AM
            StartTime = new DateTime(2022, 01, 01, 5, 0, 0),
            EndTime = new DateTime(2022, 01, 01, 6, 0, 0),
        };
        var hasConflict = MeetingConflictResolver.MeetingsConflict(meeting1, meeting2);
        Assert.That(hasConflict, Is.EqualTo(false));
    }
    
    [Test]
    public void Test8()
    {
        var meeting1 = new Meeting
        {
            // 4:00AM - 6:00PM
            StartTime = new DateTime(2022, 01, 01, 4, 0, 0),
            EndTime = new DateTime(2022, 01, 01, 18, 0, 0),
        };
        var meeting2 = new Meeting
        {
            // 12:00PM - 1:00PM
            StartTime = new DateTime(2022, 01, 01, 12, 0, 0),
            EndTime = new DateTime(2022, 01, 01, 13, 0, 0),
        };
        var hasConflict = MeetingConflictResolver.MeetingsConflict(meeting1, meeting2);
        Assert.That(hasConflict, Is.EqualTo(true));
    }
    
    [Test]
    public void Test4()
    {
        var meeting1 = new Meeting
        {
            // 12:00PM - 1:00PM
            StartTime = new DateTime(2022, 01, 01, 12, 0, 0),
            EndTime = new DateTime(2022, 01, 01, 13, 0, 0),
        };
        var meeting2 = new Meeting
        {
            // 2:15PM - 3:00PM
            StartTime = new DateTime(2022, 01, 01, 2, 15, 0),
            EndTime = new DateTime(2022, 01, 01, 3, 0, 0),
        };
        var hasConflict = MeetingConflictResolver.MeetingsConflict(meeting1, meeting2);
        Assert.That(hasConflict, Is.EqualTo(false));
    }
    
    [Test]
    public void Test5()
    {
        var meeting1 = new Meeting
        {
            // 1:00PM - 2:00PM
            StartTime = new DateTime(2022, 01, 01, 13, 0, 0),
            EndTime = new DateTime(2022, 01, 01, 14, 0, 0),
        };
        var meeting2 = new Meeting
        {
            // 12:00PM - 3:00PM
            StartTime = new DateTime(2022, 01, 01, 12, 0, 0),
            EndTime = new DateTime(2022, 01, 01, 16, 0, 0),
        };
        var hasConflict = MeetingConflictResolver.MeetingsConflict(meeting1, meeting2);
        Assert.That(hasConflict, Is.EqualTo(true));
    }
    
    [Test]
    public void Test6()
    {
        var meeting1 = new Meeting
        {
            // 1:00PM - 3:00PM
            StartTime = new DateTime(2022, 01, 01, 13, 0, 0),
            EndTime = new DateTime(2022, 01, 01, 15, 0, 0),
        };
        var meeting2 = new Meeting
        {
            // 2:00PM - 4:00PM
            StartTime = new DateTime(2022, 01, 01, 14, 0, 0),
            EndTime = new DateTime(2022, 01, 01, 16, 0, 0),
        };
        var hasConflict = MeetingConflictResolver.MeetingsConflict(meeting1, meeting2);
        Assert.That(hasConflict, Is.EqualTo(true));
    }
    
    [Test]
    public void Test7()
    {
        var meeting1 = new Meeting
        {
            // 3:00PM - 5:00PM
            StartTime = new DateTime(2022, 01, 01, 15, 0, 0),
            EndTime = new DateTime(2022, 01, 01, 17, 0, 0),
        };
        var meeting2 = new Meeting
        {
            // 2:00PM - 4:00PM
            StartTime = new DateTime(2022, 01, 01, 14, 0, 0),
            EndTime = new DateTime(2022, 01, 01, 16, 0, 0),
        };
        var hasConflict = MeetingConflictResolver.MeetingsConflict(meeting1, meeting2);
        Assert.That(hasConflict, Is.EqualTo(true));
    }
    
}