﻿namespace Demo1.UnitTests;

public class SongTests
{
    [Fact]
    public void CanCreateASong()
    {
        //project referenced (Demo1)
        var song = new Song("Fire it Up", "Modest Mouse");

        Assert.Equal("Fire it Up", song.Title);
        Assert.Equal("Modest Mouse", song.Artist);
    }
}
