using System.Collections.Generic;
using System.Globalization;
using System.Net.Sockets;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NuGet.Frameworks;
public class BowlingGame
{
    //Constructor
    List<int> score = new List<int>();
    public BowlingGame()
    {
    }

    public void Roll(int pins)
    {
        SetScore(pins); 
    }
    
    public void RollMany(int pins, int rolls)
    {
        for (int i = 0; i < rolls; i++)
        {
            Roll(pins);
        }
    }

    public void SetScore(int score)
    {
        this.score.Add(score);
        return;
    }
    public int GetScore()
    {
        int totalScore = 0;
        int rollIndex = 0;
        for (int frameIndex = 0; frameIndex < 10; frameIndex++)
        {
            int frameScore = score[rollIndex] + score[rollIndex + 1];
            if (score[rollIndex] == 10)
            {
                totalScore += score[rollIndex + 1] + score[rollIndex + 2];
            }
            if (frameScore == 10)
            {
                totalScore += score[rollIndex + 2];
            }
            totalScore += frameScore;
            rollIndex += 2;
        }
        return totalScore;
    }
    
    
}