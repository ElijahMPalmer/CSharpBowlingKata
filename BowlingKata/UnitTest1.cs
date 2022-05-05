using System.Collections.Generic;
using System.Globalization;
using System.Net.Sockets;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NuGet.Frameworks;
using Xunit;

namespace BowlingKata;



public class BowlingKata
{

    [Fact]
    public void ExpectZero()
    {
        var game = new BowlingGame();
        game.RollMany(0, 20);
            Assert.Equal(0, game.GetScore());
    }

    [Fact]
    public void ExpectTwenty()
    {
        var game = new BowlingGame();
        game.RollMany(1, 20);
        
        Assert.Equal(20, game.GetScore());
    }

    [Fact]
    public void ExpectSpare()
    {
        var game = new BowlingGame();
        game.Roll(5);
        game.Roll(5);
        game.Roll(3);
        game.RollMany(0, 17);
        Assert.Equal(16, game.GetScore());
    }

    [Fact]
    public void ExpectStrike()
    {
        var game = new BowlingGame();
        game.Roll(10);
        game.Roll(2);
        game.Roll(2);
        game.RollMany(0, 17);
        Assert.Equal(18, game.GetScore());
    }
   
    
}